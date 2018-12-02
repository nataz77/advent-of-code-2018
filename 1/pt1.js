var lineReader = require('readline').createInterface({
    input: require('fs').createReadStream('input.txt')
});
var num = 0;
lineReader.on('line', function (line) {
    num += eval(line);
});
lineReader.on('close', function(){
    console.log(num);
})


