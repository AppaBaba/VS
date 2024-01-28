.686
.model flat, stdcall
.stack 4096
ExitProcess proto, dwExitCode:dword

.code                  ; code section
main proc              ; main procedure

; do something
mov	eax, 4             ; move 4 into eax
add	eax, 5             ; add 5 to eax

invoke ExitProcess, 0  ; external process return code 0
main endp              ; main procedure end
end main               ; program end