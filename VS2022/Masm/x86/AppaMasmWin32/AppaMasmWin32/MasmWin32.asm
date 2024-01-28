.686
.model flat, stdcall

extern MessageBoxA@16 : proc
extern ExitProcess@4 : proc

.const
mes db 'Hi There!', 0
cap db 'From Appa', 0

.code
WinMain:
push 0
push offset cap
push offset mes
push 0
call MessageBoxA@16
push eax
call ExitProcess@4

End WinMain