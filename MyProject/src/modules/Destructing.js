/* try {
    let [charles, yaeshwanth, divya] = "new";
    console.log("Example 7:", charles);
  } catch (e) {
    console.error("Example 7 error:", e.message);
  } */

  try {
    let [charles, yaeshwanth, divya] = "new";
    console.log("Example 7:", charles);
  } catch (e: any) {
    console.error("Example 7 error:", e.message);
  }
  