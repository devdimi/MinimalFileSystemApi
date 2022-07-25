	Minimal File System Interface

	Goals
	1. Provide minmal but usable file system interface
	2. Allow easy unit testing when using this interface
	
	Instead of programming directly against 
	File.Read, File.Write, FileReader and StreamReader/StreamWriter you can use this interaface, 
	which to allow easy unit testing your code without actually writing/reading to the file system.
