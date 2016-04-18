NAMESPACES = -r:System.Windows.Forms.dll -r:System.Drawing.dll -r:System.Data.dll -r:NCalc.dll
all:
	@echo "\n===== Creating executables. ====="
	gmcs $(NAMESPACES) *.cs
	@echo "\n===== Running executables. ====="
	mono *.exe
	@echo "\n===== Cleaning executables. ====="
	rm *.exe
	@echo ""

prepare:
	@echo "\n===== Creating executables. ====="
	gmcs $(NAMESPACES) *.cs
	@echo ""

run:
	@echo "\n===== Running executables. ====="
	mono GUI.exe
	@echo ""

clean:
	@echo "\n===== Cleaning executables. ====="
	rm *.exe
	@echo ""

help:
	@echo "\nValid targets:"
	@echo "  all:       Create executables files, runs the executable files, and then cleans up the executable files."
	@echo "  prepare:   Creates the executable files."
	@echo "  run:       Runs the executable files."
	@echo "  clean:     Removes executale files (exe).\n"