try {
    const it: Iterator<number> = [1, 2, 2][Symbol.iterator]();
    console.log("Example 8:", it.next());
  } catch (e) {
    if (e instanceof Error) {
      console.error("Example 8 error:", e.message);
    } else {
      console.error("Example 8 unknown error:", e);
    }
  }