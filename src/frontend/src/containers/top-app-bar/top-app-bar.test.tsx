import React from 'react';
import { render, screen } from '@testing-library/react';
import TopAppBar from './top-app-bar';

test('renders learn react link', () => {
  render(<TopAppBar />);
  const loginButtonElement = screen.getByText(/Login/i)
//   const loginButtonElement = screen.getByText(/learn react/i);
  expect(loginButtonElement).toBeInTheDocument();
});