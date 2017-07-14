/**
 * @param {number} x
 * @return {boolean}
 */
var isPalindrome = function(x) {
    var xStr = x.toString();
    var len = xStr.length;
    var halfLen = len % 2 === 0 ? len / 2 : (len - 1) / 2;
    for (var i = 0; i < halfLen; i++) {
        if (xStr.charAt(i) != xStr.charAt(len - 1 - i)) return false;
    }
    return true;
};
