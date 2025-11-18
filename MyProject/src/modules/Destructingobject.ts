try {
  interface Point {
    x: number;
    y: number;
  }

  let a: Point = { x: 1, y: 2 };
  let { x: xVal }: { x: number } = a;

  console.log("Example 13:", xVal);
} catch (e: any) {
  console.error("Example 13 error:", e.message);
}