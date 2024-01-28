DrawWidth = 3
Beta1 = -16
Beta2 = -21
gamma = 600
alpha = 3

XRes = 640
YRes = 480
Modf = 8

SCREEN 12
WINDOW (1, 1)-(XRes, YRes)

FOR i = 1 TO XRes

    FOR J = 1 TO YRes
        X = Beta1 + (gamma * i)
        Y = Beta2 + (gamma * J)
        Z = alpha * (SIN(X) + SIN(Y))
        C = INT(Z)
        P = C MOD Modf

        SELECT CASE P
            CASE 0
                S = 4
            CASE 1
                S = 1
            CASE 2
                S = 14
            CASE 3
                S = 3
            CASE 4
                S = 6
            CASE 5
                S = 5
            CASE 7
                S = 9
        END SELECT

        PSET (i, J), S

    NEXT J
NEXT i

