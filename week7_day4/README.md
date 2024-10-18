## Using LBTT to Understand Design Patterns

### Design Patterns Used (Grouping)
- Behavioural (B)
- Creational (C)

### History of Patterns Used

#### 1. [B] Chain of Responsibility
Used CoR to build a linked sequence of Tax Bands with a common strategy.

#### 2. [B] Refactored CoR to use Strategy
Refactored to decouple the defined sequence and use only strategies for each Tax Band independently (with logic for accumulation) 

#### 3. [C] Factory Method
Added on Factory Method to allow creating different types of Calculator without changing the underlying logic.