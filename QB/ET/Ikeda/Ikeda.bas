c1 = 0.4
c2 = 0.9
c3 = 6
rho = .9
X = 0.1
Y = 0.1

SCREEN 12
WINDOW (-40, -30)-(40, 30)

FOR i = 0 TO 3000

    temp = c1 - c3 / (1 + X * X + Y * Y)
    sintemp = SIN(temp)
    costemp = COS(temp)

    xt = rho + c2 * (X * costemp - Y * sintemp)

    Y = c2 * (X * sintemp + Y * costemp)
    X = xt
    J = X * 20 - 10
    k = Y * 20 + 10

    PSET (J, k), 2

NEXT i

