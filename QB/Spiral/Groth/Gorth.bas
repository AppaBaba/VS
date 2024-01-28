SCREEN 12
WINDOW (-4, 3)-(4, -3)

a = 0.05
b = 0.1

PSET (a, 0), 5

FOR t = 0 TO 42 STEP 0.1

    r = a * EXP(b * t)
    X = r * COS(t)
    Y = r * SIN(t)
    LINE -(X, Y), 5

NEXT t

