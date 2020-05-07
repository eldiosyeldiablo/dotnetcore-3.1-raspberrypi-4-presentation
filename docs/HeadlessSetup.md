# Headless setup


Note that some of these instructions will be performed from a Windows 10 machine. If your machine is not a windows machine then some steps will be different.

## Configure the Pi for headless access

1. Enable SSH by placing an empty file named "ssh" (no extension) onto the boot partition of the SD card
2. Open the cmdline.txt file with a basic text editor. Note do not use editors like wordpad or Office Word.
My file before editing looked like this:

```text
console=serial0,115200 console=tty1 root=PARTUUID=5e3da3da-02 rootfstype=ext4 elevator=deadline fsck.repair=yes rootwait quiet init=/usr/lib/raspi-config/init_resize.sh splash plymouth.ignore-serial-consoles
```

3. Append this line to the end of the exiting line in the file:

```text
ip=192.168.1.200::192.168.1.1:255.255.255.0:rpi:eth0:off
```

Here is an explanation of the line above:

```text
ip=<client-ip>:<server-ip>:<gw-ip>:<netmask>:<hostname>:<device>:<autoconf>
```

My cmdline.txt after edits are completed:

```text
console=serial0,115200 console=tty1 root=PARTUUID=5e3da3da-02 rootfstype=ext4 elevator=deadline fsck.repair=yes rootwait quiet init=/usr/lib/raspi-config/init_resize.sh splash plymouth.ignore-serial-consoles ip=192.168.1.200::192.168.1.1:255.255.255.0:rpi:eth0:off
```

4. Save and close the file editor
5. Right click on the SD card in Windows Explorer and select Eject
6. Remove SD card from your machine
7. Insert the microSD card into your Raspberry Pi

### Connect via your home router, etc

If you have access to your home router configuration you can skip connecting directly from your laptop to the Pi and instead connect your Pi to your router.
Next simply go your to router's configuration screen and find the newly connected Pi to get the IP address.
Each router is different so I will not attempt to document this process any more.

Here is a sample set of instructions that you can use as a starting point if you like. [Link](http://www.jamesfmackenzie.com/2017/01/02/raspberry-pi-headless-rasbian-install/)

## Configure your Windows laptop to connect with the PI

1. Press the windows start button on your keyboard
2. Type ```ethernet```
3. Select ```Change Ethernet settings```
4. Select ```Change adapter options```
5. Right click on ```Ethernet```
6. Select ```Properties```
7. Select ```Internet Protocol Version 4...```
8. Select ```Properties```
9. Select ```Use the following IP address```
10. Enter IP Address of: 192.168.1.150
11. Enter Subnet mask of: 255.255.255.0
12. Select Ok to save your changes

## Time to test your changes

Do not boot the Rasberry Pi until the proper step below.

1. Insert the microSD card into your Raspberry Pi if you did not do that earlier
2. Connect your ethernet cable into your laptop and into the Raspberry Pi
3. Plug in the power cable to the Raspberry Pi. The Pi will immediately turn on and start it's boot sequence.
4. Open command prompt in your machine
5. Type the following to test the network connection
```ping 192.168.1.150```

## Remote into the Pi

1. Open putty on your machine
2. Connect to IP Address: ```192.168.1.200```
3. username: ```pi```
4. password: ```raspberry```

Congragulations you are now connected to your Rasberry Pi and can complete your initial setup