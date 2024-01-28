# Python 3.7.4 program for plotting the square
# Works with Anconda3 (5.2.0) using VS Python Suport
# Source code can be used in Spyder also

import scipy as sci
import matplotlib.pylab as sq
t = sci.linspace(0, 1, 100)
sq.plot(t, t**2)
sq.show()