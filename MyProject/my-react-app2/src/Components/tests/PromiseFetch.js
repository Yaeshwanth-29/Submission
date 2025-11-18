import { render, screen, fireEvent, act } from "@testing-library/react";
import PromiseFetch from "../PromiseFetch";

beforeEach(() => {
  global.fetch = jest.fn();
});

test("Promise fetch triggers API", async () => {
  const setData = jest.fn();

  fetch.mockResolvedValueOnce({
    json: async () => ({ message: "Promise fetch success" }),
  });

  render(<PromiseFetch setData={setData} />);

  fireEvent.click(screen.getByTestId("btn-promise"));

  // Flush promise chain
  await act(async () => {});

  expect(fetch).toHaveBeenCalledWith("/api/promise-data");
  expect(setData).toHaveBeenCalledWith("Promise fetch success");
});
