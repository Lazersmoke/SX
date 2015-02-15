"""
Author    :       Simon
Version   :       1.0
Name      :       S-lang
"""

import sys

c = open(sys.argv[1], 'r')
code = c.read()
code = code.replace('@@', 'self')
code = code.replace('@', 'self.')
code = code.replace('++', '+=1')
code = code.replace('--', '-=1')
code = code.replace('^', '**')
code = code.replace('j*', 'join')
code = code.replace('p*', 'print')
code = code.replace('e*', 'eval')
code = code.replace('in*', 'input')
code = code.replace('r*', 'replace')
code = code.replace('$*', 'sys')
code = code.replace('o&', 'open')
code = code.replace('im*', "import")
code = code.replace('up&', 'upper')
code = code.replace('low&', 'lower')
code = code.replace('fl*', 'math.floor')
code = code.replace('ce*', 'math.ceil')
code = code.replace('&m', 'math')
code = code.replace('&$', 'str')
code = code.replace('i&', 'int')
code = code.replace('g`', 'global')
code = code.replace('c`', 'class')
code = code.replace('m`', 'main')
code = code.replace('d`', 'def')
code = code.replace('e;', 'else')
code = code.replace('ei;', 'elif')
code = code.replace('%;', 'float')
code = code.replace('l;', 'len')
code = code.replace('M`', 'Main')
f = open(sys.argv[1] + ".py", 'w')
f.write(code)
f.close()
c.close()