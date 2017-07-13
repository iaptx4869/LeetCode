/**
 * @param {string} str
 * @return {number}
 */
var myAtoi = function(str) {
    str = str.trim();
    var index = str.trim().search(/[^+-\d]/);
    var sub;
    if (index < 0) sub = str;
    else sub = str.substr(0, index);
    var num = Number(sub);
    if (isNaN(num)) num = 0;
    if (num >= 2147483647) return 2147483647;
    else if (num <= -2147483648) return -2147483648;
    return num;
};
