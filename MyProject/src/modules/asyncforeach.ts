try {
  const ratings: number[] = [5, 4, 5];
  let sum: number = 0;

  const asyncSumFunction = async (a: number, b: number): Promise<number> => a + b;

  for (const rating of ratings) {
    sum = await asyncSumFunction(sum, rating);
  }

  console.log("Example 10:", sum);
} catch (e: any) {
  console.error("Example 10 error:", e.message);
}
