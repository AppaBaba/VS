VERSION 5.00
Begin VB.Form ET 
   Appearance      =   0  'Flat
   BackColor       =   &H00000000&
   Caption         =   "ET"
   ClientHeight    =   4020
   ClientLeft      =   1596
   ClientTop       =   2688
   ClientWidth     =   4932
   BeginProperty Font 
      Name            =   "MS Sans Serif"
      Size            =   7.8
      Charset         =   0
      Weight          =   700
      Underline       =   0   'False
      Italic          =   0   'False
      Strikethrough   =   0   'False
   EndProperty
   ForeColor       =   &H80000008&
   Icon            =   "ET.frx":0000
   LinkTopic       =   "Form1"
   PaletteMode     =   1  'UseZOrder
   ScaleHeight     =   4020
   ScaleWidth      =   4932
   Begin VB.Menu fillmenu 
      Caption         =   "&Fill"
      Begin VB.Menu mengrain 
         Caption         =   "&grain"
      End
      Begin VB.Menu menegg 
         Caption         =   "&egg"
      End
   End
   Begin VB.Menu buttmenu 
      Caption         =   "&Butt"
      Begin VB.Menu menubutt0 
         Caption         =   "butt&0"
      End
   End
   Begin VB.Menu attracmenu 
      Caption         =   "&Attractors"
      Begin VB.Menu menuikeda 
         Caption         =   "&ikeda"
      End
      Begin VB.Menu menulorenz 
         Caption         =   "&lorenz"
      End
   End
   Begin VB.Menu miramenu 
      Caption         =   "&Mira"
      Begin VB.Menu menmira 
         Caption         =   "mira&0"
      End
      Begin VB.Menu mira1 
         Caption         =   "mira&1"
      End
   End
   Begin VB.Menu iconstart 
      Caption         =   "&Icon"
      Begin VB.Menu iconb2 
         Caption         =   "Icon&2"
      End
      Begin VB.Menu icon3 
         Caption         =   "Icon&3"
      End
      Begin VB.Menu icon9 
         Caption         =   "Icon&9"
      End
   End
   Begin VB.Menu end 
      Caption         =   "&End"
      Begin VB.Menu clean 
         Caption         =   "&Clean"
      End
      Begin VB.Menu stop 
         Caption         =   "&Stop"
      End
   End
End
Attribute VB_Name = "ET"
Attribute VB_GlobalNameSpace = False
Attribute VB_Creatable = False
Attribute VB_PredeclaredId = True
Attribute VB_Exposed = False
Dim intval
Dim XRes
Dim YRes
Dim i, J, Q, P, X, Y, Z
Dim res

Dim R
Dim G
Dim B

Private Sub clean_Click()
    Cls
End Sub

Private Sub icon3_Click()
DrawWidth = 1
On Error GoTo errortrap2
GoSub initialize2

loops2:
   GoSub iterate2
   X = xnew: Y = ynew

   If zn > 0 Then C = 6
   If zn < 0.01 Then C = 4
   If zn < 0 Then C = 5
   If zn < -0.02 Then C = 1

   PSet (X, Y), QBColor(C)

restart2:
   iterates = iterates + 1
DoEvents
GoTo loops2

iterate2:
   zzbar = X * X + Y * Y
   zreal = X: zimag = Y
   For i = 1 To N - 2
      za = zreal * X - zimag * Y
      zb = zimag * X + zreal * Y
      zreal = za: zimag = zb
   Next i
   zn = X * zreal - Y * zimag
   P = lambda + alpha * zzbar + beta * zn
   xnew = P * X + gamma * zreal - omega * Y
   ynew = P * Y - gamma * zimag + omega * X
Return


initialize2:
   Scale (-1, -1)-(1, 1)
   X = 0.001: Y = 0.003: N = 5: iterates = 1
   lambda = -1.09: alpa = 1: beta = 1: gamma = 0.03: omega = 0.06

Return

errortrap2:
   X = 0.0234: Y = 0.12345
   A$ = "m"
   Resume restart2

End Sub

Private Sub icon9_Click()
DrawWidth = 1
On Error GoTo errortrap9
GoSub initialize9

loops9:

GoSub iterate9
X = xnew: Y = ynew
If zn < 1 Then C = 5
If zn > 1 Then C = 6
If zn > 2 Then C = 4
If zn > 3 Then C = 1

PSet (X, Y), QBColor(C)

restart9:
iterates = iterates + 1
DoEvents
GoTo loops9

iterate9:
zzbar = X * X + Y * Y
zreal = X: zimag = Y
For i = 1 To N - 2
za = zreal * X - zimag * Y
zb = zimag * X + zreal * Y
zreal = za: zimag = zb
Next i
zn = X * zreal - Y * zimag
P = lambda + alpha * zzbar + beta * zn
xnew = P * X + gamma * zreal - omega * Y
ynew = P * Y - gamma * zimag + omega * X
Return


initialize9:
Scale (-2, -2)-(3, 2)

X = 0.01: Y = 0.003: N = 3: iterates = 1
lambda = -1.65: alpa = 0: beta = 0: gamma = 1: omega = 0.05
Return

errortrap9:
X = 0.0234: Y = 0.12345
A$ = "m"
Resume restart9


End Sub

Private Sub iconb2_Click()

DrawWidth = 1

On Error GoTo errortrap
GoSub initialize

loops:
   GoSub iterate
   X = xnew: Y = ynew

   If zn > 0 Then C = 6
   If zn < 0.01 Then C = 4
   If zn < 0 Then C = 5
   If zn < -0.02 Then C = 1

   PSet (X, Y), QBColor(C)

restart:
   iterates = iterates + 1
DoEvents
GoTo loops

iterate:
   zzbar = X * X + Y * Y
   zreal = X: zimag = Y
   For i = 1 To N - 2
      za = zreal * X - zimag * Y
      zb = zimag * X + zreal * Y
      zreal = za: zimag = zb
   Next i
   zn = X * zreal - Y * zimag
   P = lambda + alpha * zzbar + beta * zn
   xnew = P * X + gamma * zreal - omega * Y
   ynew = P * Y - gamma * zimag + omega * X
Return


initialize:
   Scale (-1, -1)-(1, 1)

   X = 0.001: Y = 0.003: N = 9: iterates = 1
   lambda = -1.09: alpa = 1: beta = 1: gamma = 0.3: omega = 0.09
Return

errortrap:
   X = 0.0234: Y = 0.12345
   A$ = "m"
   Resume restart
End Sub

Private Sub mencls_Click()
    Cls
End Sub

Private Sub ikeda_Click()

End Sub

Private Sub menegg_Click()
    DrawWidth = 3
    Beta1 = -16
    Beta2 = -21
    gamma = 600
    alpha = 3

    XRes = 250
    YRes = 200
    Modf = 8
    Scale (1, 1)-(XRes, YRes)
    For i = 1 To XRes
        For J = 1 To YRes
            X = Beta1 + (gamma * i)
            Y = Beta2 + (gamma * J)
            Z = alpha * (Sin(X) + Sin(Y))
            C = Int(Z)

            P = C Mod Modf
            Select Case P
                   Case 0
                      S = 4
                   Case 1
                      S = 1
                   Case 2
                      S = 14
                   Case 3
                      S = 3
                   Case 4
                      S = 6
                   Case 5
                      S = 5
                   Case 7
                      S = 9
            End Select
            PSet (i, J), QBColor(S)
            DoEvents
        Next J
    Next i

End Sub

Private Sub mengrain_Click()
    DrawWidth = 3
    intval = 8
    XRes = 300
    YRes = 200
    
    Scale (1, 1)-(XRes, YRes)
    
    For i = 1 To XRes
        X = i / 50
        For J = 1 To YRes
            Y = J
            res = Y * X Mod intval
            PSet (i, J), QBColor(res)
            DoEvents
        Next J
    Next i

End Sub

Private Sub menmira_Click()
    
    DrawWidth = 1

    Scale (-20, -15)-(20, 15)
    A = 0.7
    B = 0.9998
    P = 12000
    C = 1 - 2 * A

    Rem starting point

    X = 0
    Y = 12.1
    W = A * X + C * X * X / (1 + X * X)
    For N = 0 To P
       If N > 100 Then PSet (X, Y), QBColor(5)
       If N > 3000 Then PSet (X, Y), QBColor(6)
       If N > 9000 Then PSet (X, Y), QBColor(3)

       Z = X
       X = B * Y + W
       U = X * X
       W = A * X + C * U / (1 + U)
       Y = W - Z
       DoEvents
    Next N
    
End Sub

Private Sub menubutt0_Click()
Rem Butterfly curves, developed by Temple Fay
Rem University of Southern Mississippi
Rem
pi = 3.1415
For theta = 0 To 100 * pi Step 0.01
 R = Exp(Cos(theta)) - 2 * Cos(4 * theta) + Sin(theta / 12) ^ 5
 
 Rem convert from polar coordiantes
 
 X = R * Cos(theta)
 Y = R * Sin(theta)
 
 Rem scale factors to elarge and center the curve
 
 xx = (X * 300) + 2000
 yy = (Y * 300) + 2000
 If theta = 0 Then d = 0 Else PSet (xx, yy), QBColor(3)
 
    DoEvents
Next theta
 
End Sub

Private Sub menuikeda_Click()

c1 = 0.4
c2 = 0.9
c3 = 6
rho = 1


X = 0.1
Y = 0.1
For i = 0 To 3000
 temp = c1 - c3 / (1 + X * X + Y * Y)
 sintemp = Sin(temp)
 costemp = Cos(temp)
 xt = rho + c2 * (X * costemp - Y * sintemp)
 Y = c2 * (X * sintemp + Y * costemp)
 X = xt
 J = X * 1000 + 2000
 k = Y * 1000 + 2000
 PSet (J, k), QBColor(2)
 DoEvents
Next i
End Sub

Private Sub menulorenz_Click()
frac = 8 / 3
h = 0.01
X = 0.6
Y = 0.6
Z = 0.6

npts = 4000
For i = 1 To npts
xnew = X + h * 10 * (Y - X)
ynew = Y + h * ((-X * Z) + 28 * X - Y)
znew = Z + h * (X * Y - frac * Z)
X = xnew
Y = ynew
Z = znew
J = X * 60 + 2000
k = Y * 60 + 2000

PSet (J, k), QBColor(5)
DoEvents
Next i

End Sub

Private Sub mira1_Click()

DrawWidth = 1

ReDim AA(10)
ReDim BB(10)
ReDim xx(10)
ReDim yy(10)
ReDim WXX1(6)
ReDim WYY1(6)
ReDim WXX2(6)
ReDim WYY2(6)

AA(1) = -0.4: BB(1) = 1
AA(2) = -0.4: BB(2) = 1
AA(3) = -0.2: BB(3) = 1
AA(4) = -0.48: BB(4) = 0.93
AA(5) = -0.4: BB(5) = 0.99
AA(6) = -0.25: BB(6) = 0.998

WXX1(1) = -24: WYY1(1) = -18
WXX1(2) = -40: WYY1(2) = -32
WXX1(3) = -24: WYY1(3) = -18
WXX1(4) = -16: WYY1(4) = -14
WXX1(5) = -16: WYY1(5) = -12
WXX1(6) = -16: WYY1(6) = -12

WXX2(1) = 24: WYY2(1) = 18
WXX2(2) = 40: WYY2(2) = 32
WXX2(3) = 24: WYY2(3) = 18
WXX2(4) = 16: WYY2(4) = 10
WXX2(5) = 16: WYY2(5) = 12
WXX2(6) = 16: WYY2(6) = 12

xx(1) = 4: yy(1) = 0
xx(2) = 20: yy(2) = 0
xx(3) = 10: yy(3) = 0
xx(4) = 4: yy(4) = 0
xx(5) = 4: yy(5) = 0
xx(6) = 3: yy(6) = 0


For M = 1 To 6
Cls

Scale (WXX1(M), WYY1(M))-(WXX2(M), WYY2(M))
P = 12000
C = 2 - 2 * AA(M)

W = AA(M) * xx(M) + C * xx(M) * xx(M) / (1 + xx(M) * xx(M))
For N = 0 To P
If N > 100 Then PSet (xx(M), yy(M)), QBColor(M)
Z = xx(M)
xx(M) = BB(M) * yy(M) + W
U = xx(M) * xx(M)
W = AA(M) * xx(M) + C * U / (1 + U)
yy(M) = W - Z
DoEvents
Next N
Next M

End Sub

Private Sub stop_Click()
    End
End Sub

