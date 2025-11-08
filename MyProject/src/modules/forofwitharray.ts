try {
  const arr: string[] = ['a', 'b', 'c'];

  for (const i of arr) {
    if (Object.prototype.hasOwnProperty.call(arr, i)) {
      // No-op
    }
    console.log("Example 6:", i);
  }
} catch (e: any) {
  console.error("Example 6 error:", e.message);
}
