/**
 * @param {string} s
 * @param {number} numRows
 * @return {string}
 */
var convert = function(s, numRows) {
    if (numRows <= 1) {
        return s;
    }
    var result = "";
    var step = 2 * (numRows - 1);
    for (var row = 0; row < numRows; row++) {
        for (var j = row; j < s.length; j += step) {
            result += s[j];
            if (row === 0 || row === numRows - 1) {
                continue;
            }
            var slash = j + step - 2 * row;
            if (slash < s.length) {
                result += s[slash];
            }
        }
    }
    return result;
};
