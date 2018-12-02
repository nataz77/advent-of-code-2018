var lineReader = require('readline').createInterface({
    input: require('fs').createReadStream('input.txt')
});

var num = 0;
var hits = [];

lineReader.on('line', function (line) {
    num += eval(line);
    if (hits.includes(num)) console.log(num)
    else hits.push(num);
});

lineReader.on('close', function () {
    // console.log(num);
})
