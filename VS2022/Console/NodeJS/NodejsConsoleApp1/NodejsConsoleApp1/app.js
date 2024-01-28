'use strict';

var mesage = 'Hi there';

for (var i = 31; i < 37; i++) {
    var c = i.toString();
    console.log('\x1b[' + c + 'm%s\x1b[0m', mesage);
}
