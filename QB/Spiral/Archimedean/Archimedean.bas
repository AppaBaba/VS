SCREEN 12
WINDOW (12, -9)-(-12, 9)

PI = 3.141593
a = 0.1

PSET (0, 0)

FOR t = 0 TO 16 * PI STEP 0.1

    r = a * t
    X = r * COS(t)
    Y = r * SIN(t)
    LINE -(X, Y)

NEXT t


