import { render, screen, fireEvent, act } from "@testing-library/react";
import TimeoutFetch from "../TimeoutFetch";   // <-- FIX THIS PATH

beforeEach(() => {
  jest.useFakeTimers();
  global.fetch = jest.fn();
});

test("Timeout fetch triggers API after delay", async () => {
  const setData = jest.fn();

  fetch.mockResolvedValueOnce({
    json: async () => ({ message: "Timeout fetch success" }),
  });

  render(<TimeoutFetch setData={setData} />);

  fireEvent.click(screen.getByTestId("btn-timeout"));

  await act(async () => {
    jest.runAllTimers();   // Runs setTimeout
  });

  // Helps resolve the inner async .then()
  await act(async () => {});

  expect(fetch).toHaveBeenCalledWith("/api/timeout-data");
  expect(setData).toHaveBeenCalledWith("Timeout fetch success");
});
