SCREEN 12
WINDOW (-12, 9)-(12, -9)
PI = 3.141593
a = 1.2

CIRCLE (0, 0), a
PSET (a, 0), 3

FOR n = 0 TO 100

    t = 2 * PI * n / 80
    X = a * (COS(t) + t * SIN(t))
    Y = a * (SIN(t) - t * COS(t))
    LINE -(X, Y), 3
    IF n MOD 10 = 0 THEN LINE (a * COS(t), a * SIN(t))-(X, Y), 3

NEXT n

