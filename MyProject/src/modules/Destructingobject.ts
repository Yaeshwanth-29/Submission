try {
    let a = { x: 1, y: 2 };
    let { x: xVal } = a;
    console.log("Example 13:", xVal);
  } catch (e) {
    console.error("Example 13 error:", e.message);
  }