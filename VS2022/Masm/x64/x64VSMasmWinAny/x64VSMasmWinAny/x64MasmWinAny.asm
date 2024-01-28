extern ExitProcess  :proc

.data                   ; data section
ans qword 0             ; memory location

.code                   ; code section
main proc               ; main procedure

; do something
mov rax,4               ; moves 4 to rax
add rax,5               ; add 5 to rax
mov ans,rax             ; moves rax to ans

mov ecx, 0              ; return code 0
call ExitProcess        ; External Process Called
main endp               ; main procedure end
end                     ; program end