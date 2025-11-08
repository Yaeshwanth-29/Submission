try {
  const m: Map<string, string> = new Map(
    [...'abcd'].map((x: string): [string, string] => [x, x + x])
  );

  console.log("Example 11 (Map):", m);
  console.log("Keys:", JSON.stringify([...m.keys()]));
  console.log("Values:", JSON.stringify([...m.values()]));
  console.log("Entries:", JSON.stringify([...m.entries()]));
} catch (e: any) {
  console.error("Example 11 error:", e.message);
}
