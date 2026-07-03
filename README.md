# Business Board Game

A Monopoly-style board game engine in C#. A configurable board is built from a mix of cell types (`EmptyCell`, `HotelCell`, `JailCell`, `LotteryCell`) via `CellFactory`, players move around it on dice rolls, and a `Bank` tracks money changing hands — hotel purchases, jail turns, lottery payouts.

## Design

- **`Board`** — holds the cell layout and `PlayGame(diceOutputs)` drives the full simulation from a scripted sequence of rolls.
- **`CellFactory`** — builds each cell type from the board's config string, keeping `Board` itself agnostic of cell-specific behavior.
- **`Player` / `Bank`** — player position and cash are tracked separately from board state.
- **`HotelHelper`** — encapsulates buy/rent logic for hotel cells.

**Tech:** C# / .NET

## Run

Open the solution, build, and run — dice rolls and board layout are configured in `Constants.cs`.
