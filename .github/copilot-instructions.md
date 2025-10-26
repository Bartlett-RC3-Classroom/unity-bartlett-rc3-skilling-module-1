# Unity RC3 Skilling Module AI Instructions

This educational Unity project is structured as a series of learning modules focused on Unity scripting fundamentals. When working in this codebase, follow these guidelines:

## Project Structure

- `/Assets/Scripts/School/`: Contains session-specific learning modules
- `/Assets/Scripts/Homework/`: Contains homework assignment implementations
- Main code organization follows session-based structure (Session1-5)

## Code Patterns

### Script Organization
- All behavior scripts inherit from `MonoBehaviour`
- Follow consistent structure:
  ```csharp
  using UnityEngine;
  
  public class SessionX : MonoBehaviour {
      // 1. Variables/fields
      // 2. Unity lifecycle methods (Start, Update)
      // 3. Custom methods
  }
  ```

### Naming Conventions
- Session scripts: `SessionX_YY.cs` where X=session number, YY=year
- Homework scripts: `SessionXHomework.cs`
- Class names match file names

### Common Patterns
- Use coroutines for time-based operations (see `Session4.cs`)
- Prefab instantiation with position/rotation (see `Session4_OG.cs`)
- Component access via GetComponent<T>
- Custom namespaces for specialized functionality (e.g., `RC3_9`, `OctaviansWorld`)

## Key Integration Points

1. Unity GameObject Lifecycle:
   - `Start()`: Initialization
   - `Update()`: Per-frame updates
   
2. Prefab System:
   - Create via `Instantiate()`
   - Store prefab references as public fields
   - Access components via `GetComponent<T>()`

3. Input Handling:
   - Keyboard via `Input.GetKey()`
   - Mouse via `Input.GetMouseButton()`

## Development Workflow

1. Script Creation:
   - Place new scripts in appropriate session folder
   - Inherit from MonoBehaviour
   - Implement required Unity lifecycle methods
   
2. Testing:
   - Scripts must be attached to GameObjects
   - Use Debug.Log() for visibility
   - Check console for errors/output

## Project-Specific Conventions

1. Learning Progression:
   - Session 1: Basic Unity scripting, data structures
   - Session 2: OOP concepts, control flow
   - Session 3: Unity-specific concepts, debugging
   - Session 4: Prefabs, advanced features
   - Session 5: Algorithmic implementation (Conway's Game of Life)

2. Documentation:
   - Comment major code sections
   - Include session context in headers
   - Document homework requirements inline