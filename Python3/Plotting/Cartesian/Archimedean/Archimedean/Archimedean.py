# Python 3.7.4 program for plotting Archimedean Spiral
# Works with Anconda3 (5.2.0) using VS Python Suport
# Source code can be used in Spyder also

from numpy import radians, linspace, cos, sin
from pylab import plot, show


a = .1

t = radians(linspace(0,360*3,1000))
r = t * a
x = r*cos(t)
y = r*sin(t)
plot(x,y)
show()