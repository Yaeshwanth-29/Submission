try {
    var arr = ['a', 'b', 'c'];
    for (var i of arr) {
      if (arr.hasOwnProperty(i)) {
        // No-op
      }
      console.log("Example 6:", i);
    }
  } catch (e) {
    console.error("Example 6 error:", e.message);
  }