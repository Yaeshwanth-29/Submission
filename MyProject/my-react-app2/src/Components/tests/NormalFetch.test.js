import { render, screen, fireEvent } from "@testing-library/react";
import NormalFetch from "../NormalFetch";

beforeEach(() => {
  global.fetch = jest.fn();
});

test("Normal Fetch button triggers API call", async () => {
  const setData = jest.fn();

  fetch.mockResolvedValueOnce({
    json: async () => ({ message: "Normal fetch success" }),
  });

  render(<NormalFetch setData={setData} />);

  fireEvent.click(screen.getByTestId("btn-normal"));

  expect(fetch).toHaveBeenCalledWith("/api/data");

  // wait for json()
  const call = await fetch.mock.results[0].value;
  const data = await call.json();

  expect(setData).toHaveBeenCalledWith("Normal fetch success");
});
