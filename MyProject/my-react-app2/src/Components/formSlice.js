// src/formSlice.js
import { createSlice } from '@reduxjs/toolkit';

const formSlice = createSlice({
  name: "form",
  initialState: {
    username: "",
    email: "",
    password: "",
    submitted: false,
  },
  reducers: {
    setFormData: (state, action) => {
      const { name, value } = action.payload;
      state[name] = value;
    },
    submitForm: (state) => {
      state.submitted = true;
    },
    resetForm: (state) => {
      state.username = "";
      state.email = "";
      state.password = "";
      state.submitted = false;
    },
  },
});

export const { setFormData, submitForm, resetForm } = formSlice.actions;
export default formSlice.reducer;
