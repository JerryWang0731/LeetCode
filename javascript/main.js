window.onload = () => {
    let ans = guessNumberCount(10000, 10001);
    console.log(ans);
}

// binary search 
const guessNumberCount = (maxNumber, answerNumber) => {
    let guessCount = 0;
    let left = 0;
    let right = maxNumber;
    let curr = 0;

    while(left <= right)
    {
        guessCount++;         
        curr =  parseInt((left + right) / 2);
        if(curr === answerNumber)
        {
            return {
                guessCount,
                curr
            }; 
        }

        if(curr > answerNumber){
            right = curr-1;
        } else {
            left = curr+1;
        }
        
    }
    return {
        guessCount,
        curr: -1
    }; 
}