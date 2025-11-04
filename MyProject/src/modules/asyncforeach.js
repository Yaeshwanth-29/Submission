try {
    const ratings = [5, 4, 5];
    let sum = 0;
    const asyncSumFunction = async (a, b) => a + b;
  
    ratings.forEach(async (rating) => {
      sum = await asyncSumFunction(sum, rating);
    });
  
    console.log("Example 10:", sum); // sum will still be 0 due to async behavior
  } catch (e) {
    console.error("Example 10 error:", e.message);
  }