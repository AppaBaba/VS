DrawWidth = 3

intval = 8
XRes = 300
YRes = 200

SCREEN 12
WINDOW (1, 1)-(XRes, YRes)

FOR i = 1 TO XRes
    X = i / 50
    FOR J = 1 TO YRes
        Y = J
        res = Y * X MOD intval
        PSET (i, J), res
    NEXT J
NEXT i

