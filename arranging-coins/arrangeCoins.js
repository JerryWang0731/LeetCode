/**
 * @param {number} n
 * @return {number}
 */

// --------stupid------

// const arrangeCoins = function (n) {
//   let starBucket = [];
//   let idx = 0;
//   let result = 0;

//   starBucket[0] = 0;
//   while (n > 0) {
//     starBucket[idx] += 1;
//     n--;

//     if (starBucket.length == 1 || starBucket[idx] > starBucket[idx - 1]) {
//       idx++;
//       starBucket[idx] = 0;
//     }
//   }

//   result =
//     starBucket.length > 0 && starBucket[idx] > starBucket[idx - 1]
//       ? starBucket.length
//       : starBucket.length - 1;

//   return result;
// };

// const arrangeCoins = function (n) {
//   let right = n;
//   let left = 0;

//   while (left <= right) {

//     debugger;

//     let length = left + (right - left) / 2;
//     let curr = ((1 + length) * length) / 2;

//     if (curr == n) {
//       return parseInt(left);
//     }

//     if (curr > n) {
//       right = length-1;
//     } else {
//       left = length+1 ;
//     }
//   }

//   return parseInt(left);
// };

//console.log(arrangeCoins(5));

/// ------------Ans---------------------
const arrangeCoins = (n) => {
  let left = 0;
  let right = n;
  let k;
  let curr;

  while (left <= right) {

    k = parseInt(left + (right - left) / 2);
    curr = (k * (k + 1)) / 2;

    if (curr == n) return k;

    if (n < curr) {
      right = k - 1;
    } else {
      left = k + 1;
    }
  }
  return right;
};
console.log(arrangeCoins(5));
// 1714636915

/*
n = 5

The coins can form the following rows:
¤
¤ ¤
¤ ¤

Because the 3rd row is incomplete, we return 2.
Example 2:

n = 8

The coins can form the following rows:
¤
¤ ¤
¤ ¤ ¤
¤ ¤
Because the 4th row is incomplete, we return 3.
*/
