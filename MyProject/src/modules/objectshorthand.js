try {
    let x = 3;
    let xo = { x };
    console.log("Example 4:", xo);
  } catch (e) {
    console.error("Example 4 error:", e.message);
  }
  
  try {
    let x: number = 3;
    let xo = { x };
    console.log("Example 4:", xo);
  } catch (e: any) {
    console.error("Example 4 error:", e.message);
  }
  