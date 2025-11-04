try {
    let m = new Map([...'abcd'].map(x => [x, x + x]));
    console.log("Example 11 (Map):", m);
    console.log("Keys:", JSON.stringify([...m.keys()]));
    console.log("Values:", JSON.stringify([...m.values()]));
    console.log("Entries:", JSON.stringify([...m.entries()]));
  } catch (e) {
    console.error("Example 11 error:", e.message);
  }