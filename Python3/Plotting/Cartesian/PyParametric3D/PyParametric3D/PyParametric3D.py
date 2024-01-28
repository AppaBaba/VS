# Python 3.7.4 program for plotting parametric
# Works with Anconda3 (5.2.0) using VS Python Suport
# Source code can be used in Spyder also

from mpl_toolkits.mplot3d import Axes3D
from numpy import linspace, sin, cos, pi
from pylab import title, figure, subplot, plot, legend, show

def pramplot(r):
    t = linspace(-4 * pi, 4 * pi, 100)
    x = r * sin(t)
    y = r * cos(t)
    ax.plot(x, y, z)

fig = figure()

ax = fig.add_subplot(2, 2, 1, projection='3d')
title('Parametric Hellx')
z = linspace(-2, 2, 100)
r = 5
pramplot(r)

ax = fig.add_subplot(2, 2, 2, projection='3d')
title('Parametric curve')
z = linspace(-2, 2, 100)
r = z * 2 + 5
pramplot(r)

ax = fig.add_subplot(2, 2, 3, projection='3d')
title('Parametric curve')
z = linspace(-2, 2, 100)
r = z * -2 + 5
pramplot(r)

ax = fig.add_subplot(2, 2, 4, projection='3d')
title('Parametric curve')
z = linspace(-2, 2, 100)
r = z**2 + 3
pramplot(r)
show()
