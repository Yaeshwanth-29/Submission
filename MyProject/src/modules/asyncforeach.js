/* try {
    const ratings = [5, 4, 5];
    let sum = 0;
    const asyncSumFunction = async (a, b) => a + b;
  
    ratings.forEach(async (rating) => {
      sum = await asyncSumFunction(sum, rating);
    });
  
    console.log("Example 10:", sum); 
  } catch (e) {
    console.error("Example 10 error:", e.message);
  } */
  try {
    const ratings: number[] = [5, 4, 5];
    let sum: number = 0;
  
    const asyncSumFunction = async (a: number, b: number): Promise<number> => a + b;
  
    // ✅ Use for...of for proper async/await behavior
    for (const rating of ratings) {
      sum = await asyncSumFunction(sum, rating);
    }
  
    console.log("Example 10:", sum);
  } catch (e: any) {
    console.error("Example 10 error:", e.message);
  }
  