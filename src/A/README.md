# Library A
This is an example library that can DoSomething();

This library has a hard coupling on Library B, specifically, B.DoSomething() is called by A.DoSomething();

A is now coupled to everything B is coupled to.
Since B is coupled to C, A is coupled to C. Notice both A and B need the reference to C.

This coupling creates a Big O (N) dependency, where for N libraries that reference B, N libraries also need the reference to C.
This is seen in that if n library, A1, A2, A3, ... , A100, all depend on B, then adding a depency to B requires adding a dependency to all of 100 of them.


