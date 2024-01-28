VERSION 5.00
Begin VB.Form Spirals 
   Appearance      =   0  'Flat
   BackColor       =   &H80000005&
   Caption         =   "Spirals, Trees and Stars"
   ClientHeight    =   4020
   ClientLeft      =   1092
   ClientTop       =   1776
   ClientWidth     =   4776
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
   Icon            =   "SPIRALS.frx":0000
   LinkTopic       =   "Form1"
   PaletteMode     =   1  'UseZOrder
   ScaleHeight     =   4020
   ScaleWidth      =   4776
   Begin VB.Menu Spirals 
      Caption         =   "&Spirals"
      Begin VB.Menu UnwindSpiral 
         Caption         =   "&Unwind Spiral"
      End
      Begin VB.Menu Archimedes 
         Caption         =   "&Archimedes Spiral"
      End
      Begin VB.Menu GrothSpiral 
         Caption         =   "&Groth Spiral"
      End
      Begin VB.Menu Wirlpool 
         Caption         =   "&Wirlpool"
      End
   End
   Begin VB.Menu Trees 
      Caption         =   "&Trees"
      Begin VB.Menu Pyth1 
         Caption         =   "&Pythagoras Tree"
      End
      Begin VB.Menu Pyth2 
         Caption         =   "&Lopsided Pythagoras Tree"
      End
   End
   Begin VB.Menu stars 
      Caption         =   "Sta&rs"
      Begin VB.Menu FStar 
         Caption         =   "&Fractal Star"
      End
   End
End
Attribute VB_Name = "Spirals"
Attribute VB_GlobalNameSpace = False
Attribute VB_Creatable = False
Attribute VB_PredeclaredId = True
Attribute VB_Exposed = False
Const PI = 3.141593

Private Sub Archimedes_Click()
    
    Cls
    
    Scale (12, -9)-(-12, 9)
    a = 0.1
    PSet (0, 0)
    For t = 0 To 16 * PI Step 0.1
    r = a * t
    X = r * Cos(t)
    Y = r * Sin(t)
    Line -(X, Y)
    Next t

End Sub

Private Sub FStar_Click()
Cls
Scale (-0.5, -0.8)-(1.5, 0.7)

p = 5
V = 4
a = 144
r = 0.35
a = a * PI / 180
PSet (0, 0), QBColor(4)
X = 0
Y = 0
For n = 0 To (V + 1) * V ^ (p - 1) - 1
M = n
b = n * a
F = 0

star1:
If M Mod V <> 0 Or F >= p - 1 Then GoTo star2
F = F + 1
M = Int(M / V)
GoTo star1

star2:
X = X + r ^ (p - F - 1) * Cos(b)
Y = Y + r ^ (p - F - 1) * Sin(b)
Line -(X, Y), QBColor(4)
Next n

End Sub

Private Sub GrothSpiral_Click()
    Cls
    
    Scale (-4, -3)-(4, 3)
    a = 0.05
    b = 0.1
    PSet (a, 0), QBColor(5)
    For t = 0 To 42 Step 0.1
    r = a * Exp(b * t)
    X = r * Cos(t)
    Y = r * Sin(t)
    Line -(X, Y), QBColor(5)
    Next t

End Sub

Private Sub Pyth1_Click()
Cls
Scale (-8, 8)-(8, -4)
p = 8
ReDim a(p)
X = 0: Y = 0: U = 1: V = 1
C = 1 / Sqr(2)
For M = 0 To p
  For n = 2 ^ M To 2 ^ (M + 1) - 1
    L = n: H = 1: X = 0: Y = 0: F = 0
    For K = 0 To M - 1
      a(M - K) = L Mod 2
      L = Int(L / 2)
    Next K
    X = 0: Y = 0
    For J = 1 To M
      If a(J) = 0 Then GoSub P2 Else GoSub P3
    Next J
    U = H * (Cos(F) + Sin(F))
    V = H * (Cos(F) - Sin(F))
    GoSub P1
  Next n
Next M
GoTo P4
P1:
   Line (X - V, Y - U)-(X + U, Y - V), QBColor(M + 1)
   Line -(X + V, Y + U), QBColor(M + 1)
   Line -(X - U, Y + V), QBColor(M + 1)
   Line -(X - V, Y - U), QBColor(M + 1)
Return
P2:
   X = X - H * (Cos(F) + 2 * Sin(F))
   Y = Y + H * (2 * Cos(F) - Sin(F))
   F = F + PI / 4
   H = C * H
Return
P3:
   X = X + H * (Cos(F) - 2 * Sin(F))
   Y = Y + H * (2 * Cos(F) + Sin(F))
   F = F - PI / 4
   H = C * H
Return
P4:
End Sub

Private Sub Pyth2_Click()
Cls
Scale (1.5, 1.5)-(-2, -1.5)
ReDim X(2048), Y(2048)
F = PI / 3
C = Cos(F)
S = Sin(F)
A1 = C * S
A2 = C ^ 2
B1 = A1 + A2
B2 = -A1 + A2
C1 = B2
C2 = 1 - B1
D1 = 1 - A1
D2 = 1 - A2
X(2) = 0
Y(2) = 0
X(3) = 1
Y(3) = 0
Line (0, 0)-(1, 0), QBColor(1)
Line -(1, -1), QBColor(1)
Line -(0, -1), QBColor(1)
Line -(0, 0), QBColor(1)
For M = 1 To 9
  For J = 0 To 2 ^ (M - 1) - 1
    X0 = X(2 ^ M + 2 * J)
    Y0 = Y(2 ^ M + 2 * J)
    X1 = X(2 ^ M + 2 * J + 1)
    Y1 = Y(2 ^ M + 2 * J + 1)
    U = X1 - X0
    V = Y1 - Y0
    XA = X0 + A1 * U - A2 * V
    YA = Y0 + A2 * U + A1 * V
    XB = X0 + B1 * U - B2 * V
    YB = Y0 + B2 * U + B1 * V
    XC = X0 + C1 * U - C2 * V
    YC = Y0 + C2 * U + C1 * V
    XD = X0 + D1 * U - D2 * V
    YD = Y0 + D2 * U + D1 * V
    X(2 ^ (M + 1) + 4 * J) = XA
    Y(2 ^ (M + 1) + 4 * J) = YA
    X(2 ^ (M + 1) + 4 * J + 1) = XB
    Y(2 ^ (M + 1) + 4 * J + 1) = YB
    X(2 ^ (M + 1) + 4 * J + 2) = XC
    Y(2 ^ (M + 1) + 4 * J + 2) = YC
    X(2 ^ (M + 1) + 4 * J + 3) = XD
    Y(2 ^ (M + 1) + 4 * J + 3) = YD
    Line (X0, Y0)-(XA, YA), M
    Line -(XB, YB), QBColor(M + 1)
    Line -(X1, Y1), QBColor(M + 1)
    Line -(XD, YD), QBColor(M + 1)
    Line -(XC, YC), QBColor(M + 1)
    Line -(X0, Y0), QBColor(M + 1)
  Next J
Next M

End Sub

Private Sub UnwindSpiral_Click()
    
    Cls

    Scale (12, -9)-(-12, 9)
    a = 1.2
    Circle (0, 0), a
    PSet (a, 0), QBColor(3)
    For n = 0 To 100
    t = 2 * PI * n / 80
    X = a * (Cos(t) + t * Sin(t))
    Y = a * (Sin(t) - t * Cos(t))
    Line -(X, Y), QBColor(3)
    If n Mod 10 = 0 Then Line (a * Cos(t), a * Sin(t))-(X, Y), QBColor(3)
    Next n


End Sub

Private Sub Wirlpool_Click()
    Cls
    Scale (-4 / 3, -1)-(4 / 3, 1)
    For p = 3 To 8
    Cls
    ReDim X(p), Y(p)
    b = 0.05
    a = PI * (1 - 2 / p)
    C = Sin(a) / (Sin(b) + Sin(a + b))
    For K = 0 To p
        t = (2 * K + 1) * PI / p
        X(K) = Sin(t)
        Y(K) = Cos(t)
    Next K
    For n = 1 To 64
        PSet (X(0), Y(0))
        For L = 1 To p
            Line -(X(L), Y(L)), QBColor(1)
        Next L
        For M = 0 To p
            z = X(M)
            X(M) = (X(M) * Cos(b) - Y(M) * Sin(b)) * C
            Y(M) = (z * Sin(b) + Y(M) * Cos(b)) * C
        Next M
    Next n
    Next p

End Sub

