.686
.model flat, stdcall
.stack 4096
ExitProcess proto, dwExitCode:dword

.data                       ; data section
rcode dword ?               ; return exit code

.code                       ; code section
main proc                   ; main procedure

; do something
mov	eax, 4                  ; move 4 into eax
add	eax, 5                  ; add 5 to eax
imul eax, 2                 ; Integer Multiplication by two
inc eax                     ; increments eax by one
sub eax, 6                  ; subtract 6 from eax
dec eax                     ; decrements eax by one
mov rcode, eax              ; return code

invoke ExitProcess, rcode   ; external procedure exit return code
main endp                   ; main procedure end
end main                    ; program end