try {
    let it = [1, 2, 2][Symbol.iterator]();
    console.log("Example 8:", it.next());
  } catch (e) {
    console.error("Example 8 error:", e.message);
  }
  
  
  