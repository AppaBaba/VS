extern GetStdHandle : proc    
extern WriteFile    : proc
extern ExitProcess  : proc

Console equ -11  

.data
cap   byte 'Hi from Appa'
mes   byte 'Hi there!', 13, 10
StdOut    qword ?
NumBytes  dword ?

.code                      ; code section
main proc                  ; main procedure
sub rsp, 40                ; reserve 40 bytes of Shadow space
and spl, -16               ; Align to 16

mov ecx, Console           ; request StdOutputHandle
call GetStdHandle          ; external procedure called to get console handle
mov StdOut, rax            ; moves StdHandle to StdOut memory location

; Display
mov rcx, StdOut            ; pass the handler as the first argument
lea rdx, mes               ; string address as the second argument 
lea r9, NumBytes           ; number of bytes written as the third argument
mov r8d, LENGTHOF mes      ; length of message as the forth argument
mov qword ptr [rsp+32], 0  ; lpOverlapped = NULL
call WriteFile             ; external procedure called write to console

mov rcx, 0                 ; rcx to null for return value
call ExitProcess           ; external process called to exit
main endp                  ; main procedure end
end                        ; program end