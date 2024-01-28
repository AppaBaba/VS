extern ExitProcess  :proc

.code              ; code section
main proc          ; main procedure
                   
; does nothing
; add coce here

mov   ecx, 0       ; return code 0
call  ExitProcess  ; External Process Called
main endp          ; main procedure end
end                ; program end