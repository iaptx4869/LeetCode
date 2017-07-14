/**
 * @param {number} x
 * @return {number}
 */
var reverse = function(x) {
    var y = 0;
    while (x) {
        y = y * 10 + x % 10;
        x = parseInt(x / 10);
    }
    if (y > Math.pow(2, 31) || -y > Math.pow(2, 31)) {
        y = 0;
    }
    return y;
};

/**
 * @param {number} x
 * @return {number}
 */
var reverse = function(x) {
    if (x === 0) return 0;
    var xAbs = x > 0 ? x : -x;
    var y = 0;
    while (xAbs > 0) {
        y = y * 10 + xAbs % 10;
        xAbs = Math.floor(xAbs / 10);
    }
    if (y >= 2147483651) y = 0;
    return x > 0 ? y : -y;
};
