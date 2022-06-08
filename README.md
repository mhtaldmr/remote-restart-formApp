# Remote Restart from another pc

A simple interface project to start a bat file when selected.

### What I have used so far:

- Windows form project with `.Net6` windows form app.

## Goals

- To restart a pc without pressing any button on it.
- To restart a pc without connecting by remote desktop also.
- Just to write a command in command promt and restart pc by remotely.

###  The Command

- .bat file contains the command below for connecting the remote pc.

```c
net use \\192.168.30.100 Password  /user:UserName
shutdown -r -f -m \\192.168.30.100
exit
```
> IP adress needs to be replaced by the target pc ip..
> UserName and Password needs to be replaced by the target pc informations.
