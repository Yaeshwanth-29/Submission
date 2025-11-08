/* try {
    let vals = [];
    for (let x = 0; x < 4; x += 1) {
      vals.push(() => x);
    }
    console.log("Example 2:", vals.map(x => x()));
  } catch (e) {
    console.error("Example 2 error:", e.message);
  } */

  try {
    const vals: Array<() => number> = [];
  
    for (let x = 0; x < 4; x += 1) {
      vals.push(() => x);
    }
  
    console.log("Example 2:", vals.map(fn => fn()));
  } catch (e: any) {
    console.error("Example 2 error:", e.message);
  }
  