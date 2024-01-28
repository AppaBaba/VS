.686
.model flat,stdcall
.stack 4096
ExitProcess proto,dwExitCode:dword

.code                        ; code section
main proc

; do nothing

invoke ExitProcess, 0        ; external procedure return 0
main endp                    ; main procedure end
end main                     ; program end