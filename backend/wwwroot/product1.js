const products = {
    hik1: {
        name: "HIKVISION HD Bullet 2.0MP AUDIO DS-2CE16D0T-ITPF",
        price: "₹1,413",
        desc: `
About this product:
• Model: DS-2CE16D0T-LPFS
• High-quality imaging with 2 MP (1920×1080)
• 2.8 mm / 3.6 mm fixed focal lens
• Up to 25 m IR night vision
• Water & dust resistant (IP67)`,
        img: "images/hik1.jpg"
    },

    hik2: {
        name: "HikVision DS-2CE5AC0T Dome Camera",
        price: "₹1,520",
        desc: `About this item
• Hikvision 720p 1 mp dome camera DS-2CE5ACOT-IRP eco 1 pc.
• 1.0 Megapixel high-performance CMOS
• Analog HD output, up to 720P resolution True Day/Night,DNR, Smart IR
• Up to 20m IR distance,3.6mm Lens Switchable TVI/AHD/CVI/CVBS`,
        img: "images/hik2.webp"
    },

    hik3: {
        name: "Hikvision IP 2MP Bullet H.265+ Network CCTV",
        price: "₹5,199",
        desc: `2 MP Outdoor WDR Fixed Mini Bullet Network Camera
• High quality imaging with 2 MP resolution
• Efficient H.265+ compression technology
• Clear imaging against strong back light due to 120 dB true WDR technology
• Water and dust resistant (IP67)
• Robust structure design with full metal materials.`,
        img: "images/hik3.webp"
    },

    hik4: {
        name: "HIKVISION 5Mp/1080p [Built-in Audio Mic | Color Night Vision] Outdoor Wired Color CCTV Camera for Dvr, Ds-2Ce70Kf0T-Pfs White",
        price: "₹2,699",
        desc: `About this item
• Hikvision 3K ColorVu Indoor Audio Fixed Turret Camera
• Compatible with 5 MP & aboove DVR only
• For Indoor Use Only
• Built-In MIc`,
        img: "images/hik4.jpg"
    },

    hik5: {
        name: "HIKVISION DS-2AE4123TI-D PTZ Dome Camera",
        price: "₹19,588",
        desc: `About this item
• 1/3' Progressive Scan CMOS
• 1280×720
• 23X Optical Zoom
• DWDR
• Up to 100m IR distance
• 3D intelligent positioning function
• Support Turbo HD and BNC output`,
        img: "images/hik5.jpg"
    },



    hik6: {
        name: "Hikvision DS-2DE2C400SCG-E(F0)(O-STD) (2560 x 1440 Pixels), Network camera, Black, White",
        price: "₹8,269",
        desc: `About this item
• 1/3' Progressive Scan CMOS
• 1280×720
• 23X Optical Zoom
• DWDR
• Up to 100m IR distance
• 3D intelligent positioning function
• Support Turbo HD and BNC output`,
        img: "images/hik6.webp"
    },


    hik7: {
        name: "AHD, HD-CVI, HD-TVI, PAL CAMERA DS-2CE76D0T-LPFS(2.8MM) - 1080p Hikvision",
        price: "₹5,152",
        desc: `About this item
• Hikvision
• 4-in-1 Value Range Dome Camera
• Resolution 1080p (1920x1080)
• 2.8mm Lens | Suitable for indoor use
• Dual light: Smart IR 20m and white light 20m
• Audio over coaxial cable | Built-in microphone`,
        img: "images/hik7.webp"
    },


    hik8: {
        name: "Hikvision 5MP White Ultrahd Infrared Cctv Bullet Camera, DS-2CE1AHOT-ITPF",
        price: "₹2,282",
        desc: `About this product
• Brand Hikvision
• Night Vision Yes`,
        img: "images/hik8.webp"
    },



    hik9: {
        name: "Hikvision 2 Mp Manual Varifocal Turret Camera",
        price: "₹2,250",
        desc: `About this product
• High quality imaging with 2 MP, 1920 × 1080 resolution
• 2.7 mm to 13.5 mm varifocal lens
• Up to 40 m IR distance for bright night imaging
• One port for four switchable signals (TVI/AHD/CVI/CVBS)
• Water and dust resistant (IP67)`,
        img: "images/hik9.jpg"
    },


    hik10: {
        name: "Hikvision 4K CMOS Sensor Outdoor Network Camera",
        price: "₹15,265",
        desc: `About this product
• High quality imaging with 8 MP resolution
• Efficient H.265+ compression technology
• Clear imaging against strong back light due to 120 dB true WDR technology
• Water and dust resistant (IP67)
• Robust structure design with full metal materials.`,
        img: "images/hik10.webp"
    },




    cp1: {
        name: "CP Plus EZ P21 Security Camera",
        price: "₹1,199",
        desc: `About this product
• 0.552 cm (1/4.6 inch) 2 MP CMOS Image Sensor
• 4 mm Lens
• H.264 Video Compression
• Wi-Fi Support`,
        img: "images/cp1.webp"
    },


    cp2: {
        name: "2MP CP-Plus Eezo Wi-Fi Cube Camera CB21",
        price: "₹2,599",
        desc: `About this item
• Human Detection, Motion Alert, Two-way Talk, Abnormal Sound Alarm`,
        img: "images/cp11.webp"
    },


    cp3: {
        name: "CP Plus EZ P21 Security Camera",
        price: "₹1,199",
        desc: `About this product
• 2.4MP CMOS Image Sensor
• Max 25/30fps at 2.4MP
• DWDR, Day/Night (ICR), 2D-DNR, AWB, AGC, BLC
• 3.6mm Fixed lens, Illumination Distance of 20 Mtrs, IP67
• Support Built-in Mic, 24/7 color Imaging`,
        img: "images/cp3.webp"
    },

    cp4: {
        name: ">CP PLUS CP-E35A 3MP Full HD Smart Wi-Fi CCTV Camera",
        price: "₹1,899",
        desc: `About this product
• Motion Tracking: Enjoy effortless monitoring as the camera automatically rotates to track the movement of people, ensuring no activity goes unnoticed.
• Motion Detection Alerts: Stay informed with real-time alerts as the camera detects movement in the video frame, keeping you updated on any potential activity.`,
        img: "images/cp4.webp"
    },

    cp5: {
        name: "CP Plus 5MP HD Outdoor Bullet Camera",
        price: "₹2,359",
        desc: `About this product
• 1/2.7” 5MP CMOS Image Sensor (0.9407 cm) | Max. 25fps@5MP (16:9 video output)
• DWDR, Day/Night (ICR), 2D-DNR, AWB, AGC, BLC, HLC
• 3.6mm fixed lens (2.8mm optional)
• IR Range of 20 Mtrs., IP67
• OSD Menu, control over coaxial cable, 2D-DNR | CVI/CVBS/AHD/TVI Switchable
• Material Type: Plastic; Included Components: Camera Body, Bolts & Nuts`,
        img: "images/cp5.jpg"
    },


    cp6: {
        name: "CP PLUS 2 MP Full HD Smart Wi-fi CCTV Camera | 115° Angle of View | Built-in Mic | Motion Tracking & Detection Alert | Built-in 16x Digital Zoom",
        price: "₹2,450",
        desc: `About this product
• Human Detection, Motion Alert, Two-way Talk, Abnormal Sound Alarm`,
        img: "images/cp12.jpg"
    },

    cp7: {
        name: "CP PLUS 2 MP Full HD Smart Wi-fi CCTV Camera | 115° Angle of View | Built-in Mic | Motion Tracking & Detection Alert | Built-in 16x Digital Zoom",
        price: "₹2,849",
        desc: `About this product
• Directly Supplied from CP Plus.
• Privacy Mode.`,
        img: "images/cp7.webp"
    },


    cp8: {
        name: "CP Plus Wi-Fi Pt Security Camera",
        price: "₹1,449",
        desc: `About this product
• 3MP Camera for Vivid Video - Enjoy enhanced picture quality to capture every detail in 1296p resolution video feed with vivid clarity.
• 2-Way Talk - Enjoy two-way communication through your Smart Phone from anywhere.
• 360⁰ Coverage - keep an eye all over the place with 360° view.
• Supports Human Body Detection - Effectively detects human movements and send alerts in real-time to reduce false alarms.
• Privacy Mode – Using privacy mode, you can block the camera view & recording to maintain privacy.`,
        img: "images/cp8.webp"
    },

    cp9: {
        name: "CP PLUS 2MP Full-Color Guard+ Network IR Dome 1080p Camera",
        price: "₹3,350",
        desc: `About this product
• Smart H.265 And Smart H.264 Dual-Stream Encoding
• 1/28 2Megapixel Ps Cmos Image Sensor 7112 Cm
• Dwdr, Day/Night Icr, 3D-Dnr, Roi, Awb, Agc, Blc, Hlc
• Mobile Software: Icmob, Gcmob, Max. 2Mp1920 X 1080@25/30Fps
• Built-In Efficient Led Illuminator, And The Max. Illumination Distance Is 20 Mtr`,
        img: "images/cp13.jpg"
    },

    cp10: {
        name: "CP Plus 2MP Full-Color Guard+ Network IR Bullet Camera",
        price: "₹2,999",
        desc: `About this product
• 1/2.8” 2Megapixel PS CMOS Image Sensor (0.9071 centimeters) | Max. 2MP(1920 x 1080)@25/30fps
• Smart H.265+ and Smart H.264+ dual-stream encoding | DWDR, Day/Night (ICR), 3D-DNR, ROI, AWB, AGC, BLC, HLC
• 3.6mm fixed lens (2.8mm optional) | Support IP67, PoE
• Built-in efficient LED illuminator, and the max. illumination distance is 20Mtr. | Mobile Software: iCMOB, gCMOB
• CMS Software: KVMS Pro`,
        img: "images/cp14.webp"
    },

    dah1: {
        name: "Dahua DH-HAC-T1A21-U-IL-A 2mp 2.8mm Akıllı Işık Hdcvi Sesli Dome Kamera",
        price: "₹1,198",
        desc: `About this product
• Dahua DH-HAC-T1A21-U-IL-A 2MP 2.8mm Smart Light HDCVI Audio Dome Camera
• Max. 30 fps@1080p.
• Smart Dual Light.
• 25 m lighting distance.
• Built-in MIC.
• The quick-assembly eyeball saves on setup time.
• 2.8 mm fixed lens
• CVI/CVBS/AHD/TVI are switchable.`,
        img: "images/dah1.webp"
    },

    dah2: {
        name: "DAHUA IP BULLET 2.0MP",
        price: "₹2,000",
        desc: `About this product
• Dahua IP Bullet 2.0MP is a great, affordable IP camera that can be used to monitor your home or office. This camera has a 2.0MP 
     resolution, which is enough to capture clear images and videos.
• The IP Bullet also has a built-in night vision feature, which makes it perfect for monitoring dark areas.`,

        img: "images/dah2.webp"
    },


    dah3: {
        name: "Dahua Y26P3aj7vz Network Camera",
        price: "₹2,650",
        desc: `About this product
• The Dahua H4A Hero is a state-of-the-art network camera designed for surveillance and security in various environments.
• This camera is ideal for use in residential and commercial spaces, as it provides a reliable monitoring solution.
• The Dahua H4A Hero is equipped with advanced features that ensure effective surveillance, including motion detection and night vision`,
        img: "images/dah3.webp"
    },

    dah4: {
        name: "Dahua CCTV 2MP Smart Dual Light HDCVI Fixed-focal Bullet Camera",
        price: "₹2,917",
        desc: `About this product
• With a maximum image resolution of 1920 x 1080 pixels, this camera provides clear and detailed image quality, essential for capturing important details in surveillance applications
• The camera features a fixed lens that ensures reliable and consistent image capture.
•  This camera is an ideal solution for security applications in residential and commercial spaces that require reliable and high-quality monitoring.`,
        img: "images/dah4.webp"
    },

    dah5: {
        name: "Dahua CCTV 2MP HDCVI IR Vandal-proof Dome Camera",
        price: "₹6,291",
        desc: `About this product
• Maximum IR range of up to 60 meters for night surveillance
• True WDR with 130 dB for improved image quality in backlight conditions
• Multi-format output via a BNC connector
• Sturdy design with IK10 protection against vandalism
• Easy installation through ceiling mounting.`,
        img: "images/dah5.webp"
    },




    true1: {
        name: "Trueview Bullet CCTV Security Camera",
        price: "₹3,069",
        desc: `About this product
• Cutting-Edge Vision Technology: Explore our 4g sim based extensive range of products boasting an 'All time color vision' feature, ensuring vivid and clear visuals.
• Enhanced Communication Systems: Elevate your security measures with Full Duplex Audio Intercom functionality, allowing seamless two-way communication.
• Optimized Night Vision: Our products incorporate a sophisticated Infrared and white dual-light design, accompanied by 3 adjustable night vision modes.     `,
        img: "images/true1.webp"
    },



    true2: {
        name: "Trueview IP POE SMART 5MP ATC BULLET CAMERA",
        price: "₹2,299",
        desc: `About this product
• All Time Color Vision
• Built-in High Sensitivity Mic
• Power Input : POE 48V Standard/ DC 12V 1Amp
• Support ONVIF protocol
• 4KV lightning protection
• Compression: H.264/H.265/H.264+/H.265+ Features:
• 4K Ultra HD resolution
• Night vision
• Wide-angle lens
• Easy to install
• Weatherproo `,
        img: "images/true2.avif"
    },




    true3: {
        name: "Trueview Wireless Cctv Camera",
        price: "₹4,719",
        desc: `About this product
• The Trueview Outdoor WiFi CCTV Camera is designed to withstand tough weather conditions.
  Whether it’s blazing heat, pouring rain, or freezing temperatures, this camera keeps working without interruption.
  Its weatherproof casing protects it from the elements, so you get reliable security all year long.
• Clear video is essential for good surveillance. The Trueview WiFi Bullet Camera records high-definition video,
 so you can see detailed images of everything happening around your property. 
• Our cameras have a wide-angle lens that lets you cover more space. You can see a larger area around your property,which cuts down on blind spots and gives you better overall coverage of your outdoor spaces.      `,
        img: "images/true3.webp"
    },




    true4: {
        name: "Trueview Security CCTV Camera for Desktop White ,T18100",
        price: "₹3,064",
        desc: `About this product
• Recommended Uses For Product -	Night Vision
• Brand  - Trueview
• Model Name -	Trueview Ultra POE
• Special Feature - 3 mp
• Indoor/Outdoor Usage -	Indoor, Outdoor
• Compatible Devices  -	Laptop
• Controller Type	 - Android
• Number of Items -1
• Wireless Communication Technology - Ir
• Form Factor  - Bullet `,
        img: "images/true4.webp"
    },




    true5: {
        name: "Trueview Security CCTV Camera for Desktop White , T18100",
        price: "₹3,185",
        desc: `About this product
• This Product is Supplied from Trueview Brand.
• Simple, Reliable & Secure.
• Wall Lamp Operation at Night with Bright White LEDs.
• Audio Intercom with Built-in Omnidirectional Noise Reduction Microphone & Speaker.
• Antenna Design for 100 m Long Wi-Fi Connectivity & Intelligent Night Vision Modes with White & Infrared LEDs.`,
        img: "images/true5.webp"
    },

    dvr1: {
        name: "HIKVISION 8 Channel DVR 1080P Lite",
        price: "₹3,999",
        desc: `About this product
• 8 Channel DVR
• 1080P Lite Recording
• H.265 Pro+
• HDMI & VGA Output
• Mobile Viewing`,
        img: "images/dvr1.jpg"
    },

    nvr1: {
        name: "Hikvision AcuSense NVR",
        price: "₹9,189",
        desc: `About this product
• Supports IP Cameras
• 4K Recording
• AI Motion Detection
• H.265 Compression
• Mobile App Support`,
        img: "images/nvr1.webp"
    },

    nvr2: {
        name: "Hikvision DS-9664NI-M8 M-Series 8K 64-Channel 32MP NVR H.265, 8 SATA No HDD Included",
        price: "₹1,635",
        desc: `About this product
• Up to 64-ch IP camera inputs
• 2 HDMI (different source) and 2 VGA (different source) interfaces, 8K or dual 4K video outputs
• Supports special cameras, including people counting camera, ANPR (automatic number plate recognition) camera, and fisheye camera
• Advanced streaming technology enables smooth live view in poor network conditions`,
        img: "images/nvr2.jpg"
    },

    nvr3: {
        name: "Hikvision USA NVR Digital Video Recorder DS9616NII88TB",
        price: "₹4,00,933",
        desc: `About this product
• Up to 12 MP Resolution Recording
• Synchronous 2-ch HDMI, 2-ch VGA, and HDMI1 4K (3840 x 2160) Resolution
• Connect Up to 16 IP Cameras with 320 Mbps Incoming Bandwidth
• HDD Hot-Swap with Configurable RAID 0, RAID 1, RAID 5, RAID 6, RAID 10
• Third-Party Network Cameras Supported`,
        img: "images/nvr3.jpg"
    },


    nvr4: {
        name: "Hikvision 8K 32 Channel NVR 16Ch-Poe 32MP H.265 4X SATA DS-7732NI-M416P No HDD Included",
        price: "₹1,00,000",
        desc: `About this product
• Shop Hikvision DS-7732NI-M424P 32-ch Ultra Series 8K NVR, 24-ch PoE, up to 32MP, H.265, 4X SATA No HDD Included online at a best price in India. B0CPB1884B`,
        img: "images/nvr4.jpg"
    },

    hon1: {
        name: "Honeywell Cat 6 SFTP Cable",
        price: "₹14,999",
        desc: `About this product
• True 23 AWG Solid Bare Copper.
• 305 Mtrs. Reel. 500 Mtrs. Reel in Optoin.
• FR-PVC (LSZH Sheath Option on Demand)
• Jacket Colors on Demand.
• Channel Performance Warranty
• Performance Verified Upto 600 MHZ.
• Well Exceeds The Requirements of ANSI/TIA 568-C.2 Category 6 and ISO 11801 Class E.
• Country of Origin: Hong Kong.`,
        img: "images/hon1.webp"

    },

    hon2: {
        name: "Honeywell LAN Cable 305 m Cat 6A UTP 4 Pair Solid Cable 23 AWG FRPVC 305Mtrs",
        price: "₹14,999",
        desc: `About this product
• HONEYWELL Cat6A UTP Cable 4 Pairs is suitable for Horizontal Cabling Systems. Used to transmit High Speed Data. 
• Voice and Video signals both digital & analog through entire CHANNEL.
• With 500 MHz operational bandwidth it well exceeds the requirement of ANSI/TIA 568-C.2 and ISO 11801`,
        img: "images/hon2.jpg"

    },

    hon3: {
        name: "Honeywell Genesis Control Cable 1000ft Yellow",
        price: "₹2,400",
        desc: `About this product
• When it comes to high-performance, low-voltage cable for any application, Genesis Cable works with you to consistently deliver results you can count on.`,
        img: "images/hon3.webp"

    },

    hon4: {
        name: "Honeywell Genesis Cat6+ Riser Rated Network Cable",
        price: "₹7,999",
        desc: `About this product
• When it comes to high-performance, low-voltage cable for any application
• Honeywell Cable works with you to consistently deliver results you can count on..`,
        img: "images/hon4.webp"

    },

    hon5: {
        name: "Honeywell HDMI Cable 3m Black",
        price: "₹1,999",
        desc: `About this product
• Powerful & High-speed data transmission upto 10.2 GBPS & refresh rate of 340MHz
• Enjoy gaming, streaming movies & Sports in a seamless cinematic resolution of 3D/4Kx2K Ultra HD
• Blu-ray with 3D technology in 1080P`,
        img: "images/hon5.webp"

    },


    cab1: {
        name: "CP PLUS Heavy Duty Outdoor Cat6 UTP Cable 100 Meter | 4 Pair LAN Cable for CCTV & Network | high-density HDPE Insulation",
        price: "₹1,999",
        desc: `About this product
• 100M Cat6 Cable – Ideal for CCTV cameras, DVRs, routers & switches
• 4 Pair UTP LAN Cable – Unshielded twisted pair for enhanced transmission stability
• High-Speed Network Cable – Designed for smooth data, video & voice transfer
• Durable HDPE Insulation – Resists cracking, bending & electromagnetic interference
• Supports Analog & IP CCTV Systems – Perfect LAN cable for home or commercial security`,
        img: "images/cab1.jpg"

    },

    cab2: {
        name: "CP PLUS CCTV Camera Cable",
        price: "₹1,231",
        desc: `About this product
• CP PLUS 3+1 CCTV Cable (Eco Cable)
• Solid Annealed Bare Copper Conductor | LLDPE Insulation Material
• Insulation: PVC, Type A, Jacket(Overall): PVC Type 1.8mm
• Ideal Co-axial cable for home and Office security cameras
• CP PLUS Cable is Tough and tensile, Excellent coating, Well insulated, Long lasting`,
        img: "images/cab2.jpg"

    },

    cab3: {
        name: "CP PLUS Plastic, Copper White 90 M Wire (White) 3+1, 4 Pin, White",
        price: "₹1,394",
        desc: `About this product
• Colour: White
• Solid copper cable
• For CCTV camera
• Pack of 1`,
        img: "images/cab3.jpg"

    },

    cab4: {
        name: "CP PLUS 3+1 Outdoor CCTV Cable with High Protection – CP-ECC-90RSO",
        price: "₹1,250",
        desc: `About this product
• The CP PLUS CP-ECC-90RSO 3+1 Outdoor CCTV Cable Coaxial is engineered for high conductivity, superior insulation, and weather-resistant durability.
• Featuring a solid annealed bare copper conductor and LLDPE/PE sheath, it ensures stable video, power, and audio transmission even in outdoor environments.
• A perfect choice for reliable and long-lasting CCTV installations.`,
        img: "images/cab4.jpeg"

    },



    cab5: {
        name: "CP Plus CP-EUT-6TGL23-100 Cat 6 100 meter Cable with High Speed connectivity",
        price: "₹2,749",
        desc: `About this product
• Solid bare Copper Conductor
• Renewed Capacity
• Increased Protection
• Weather Care
• Heavily Braided with HDPE Insulation`,
        img: "images/cab5.jpg"

    },


    dli1: {
        name: "D Link Cat6 Outdoor Cable, UTP, 4 Pair",
        price: "₹11,500",
        desc: `About this product
• Enhanced performance cable for transmission of high speed data, digital and analogue voice and video (RGB) signals on LANs.
•  Supports Gigabit Ethernet (1000 BaseT) standard. Operates at bandwidth of 250 MHz.
• This cable well exceeds the requirements of TIA/EIA568-C.2 and ISO/IEC 11801 and RoHS compliant`,
        img: "images/dlink1.webp"

    },

    dli2: {
        name: "D25 LAN Cable 100 m COPPER Compatible With D_Link Cat6 Networking Cable for Router UTP Outdoor 100Meter Box",
        price: "₹11,500",
        desc: `About this product
• Cat6 Heavy Duty Networking Cable UTP Outdoor 100 meters Cable
• Blazing-Fast Speeds Experience the thrill of 1000mbps Ethernet speeds.
•  Reliable Security Cameras Ensure the safety of your property with confidence.`,
        img: "images/dlink2.webp"

    },

    dli3: {
        name: "D-Link Cat 6 Networking Cable for Router UTP",
        price: "₹6,999",
        desc: `About this product
• 100% Copper and no mix of other material
• The speed of a wired LAN is largely determined by how fast data is transmitted between computers and network components.
• The solid construction of the Technotech Cat6 cable helps you stream video, music, transmit data at higher speeds by providing a fast and reliable connection.
•  Note: A network's speed is determined by many factors in addition to the cables, including your router, switch boxes and component.`,
        img: "images/dlink3.jpg"

    },


    dli4: {
        name: "D-LinkCCTV Cable",
        price: "₹10,500",
        desc: `About this product
• Support Hybrid Cable
• Shielded Communication cable
• Excellent Signalling Characteristics
• Conductor type : Solid Annealed Bare Copper Conductor`,
        img: "images/dlink4.jpg"

    },


    dli5: {
        name: "Copper 305m D Link Cat6 Outdoor Cable, UTP, 305 Mtr",
        price: "₹9,000",
        desc: `About this product
• D-Link BLACK CAT6 305 meter Armored LAN Cables are underground or outdoor all weather proof cabling that offers
  lowest signal loss and supports Gigabit Ethernet (1000Base-T) standard that operates at 250MHz.
• It works on full duplex mode, comes with 23AWG twisting and are further insulated with HDPE and FR-PVC and Aluminum Wire Armoring.
•  D-Link CAT6 Cables are UL Listed, ETL, EIA/TIA C.2 verified. It can also support 2.5Gbps, 5Gbps and 10Gbps at limited distances with compatible devices.`,
        img: "images/dlink6.webp"

    },

    rt1: {
        name: "TP-Link Archer AX12 WiFi6 Router AX1500 1xGb WAN Dual-Band",
        price: "₹3,625",
        desc: `About this product
• Wi-Fi 6 Technology: Archer AX12 comes equipped with the latest wireless technology, Wi-Fi 6, for faster speeds, greater capacity and reduced network congestion
• Next-Gen 1.5 Gbps Speeds: Archer AX12 dual-band router reaches even faster speeds up to 1.5 Gbps (1201 Mbps on 5 GHz band and 300 Mbps on 2.4 GHz band)
• Connect More Devices: Wi-Fi 6 technology communicates more data to more devices using revolutionary OFDMA and MU-MIMO technology while simultaneously reducing lag
• More Reliable Coverage: Achieve the strongest, most reliable WiFi coverage with Archer AX12 as it focuses signal strength to your devices using Beamforming technology and four antennas
• Increased Battery Life: Target Wake Time technology reduces your devices' power consumption to extend their battery life`,
        img: "images/tp1.jpg"

    },

    rt2: {
        name: "TP-Link TL-WR850N N300 Wi-Fi Router",
        price: "₹1,059",
        desc: `About this product
• 300Mbps wireless transmission rate ideal for both bandwidth sensitive tasks and basic work
• Supports Aginet Config- Enable ISPs to customize default configurations by themselves
• Parental Controls manage when and how connected devices can access the internet
• IPTV supports IGMP Proxy/Snooping to optimize IPTV streaming
• Compatible with IPv6 (Internet Protocol version 6)
• Guest Network provides separate access for guests while securing the home network`,
        img: "images/tp2.jpg"

    },


    rt3: {
        name: "TP-Link Archer AX23 AX1800 Dual-Band Wi-Fi 6 Router (1800 Mbps Speed Gigabit Wireless ",
        price: "₹3,899",
        desc: `About this product
• Super-Fast 1.8 Gbps Wi-Fi —— Enjoy smooth 4K streaming and downloading with super-fast Wi-Fi speeds of 1.8 Gbps.;Connect More Devices 
   Communicates with more devices using OFDMA while simultaneously reducing lag.
• Broader Coverage —— Improved algorithm, beamforming, and high-performance antennas enhance the Wi-Fi coverage performance.
• The Next-Gen High-Efficiency Chipset provides fast and stable Wi-Fi while saving power consumption.
• IPTV support works with your existing TV over the Internet contract. `,


        img: "images/tp3.jpg"

    },


    rt4: {
        name: "TP-Link Archer BE400 Dual-Band BE6500 WiFi 7 Router ",
        price: "₹3,899",
        desc: `About this product
• Enables your devices to run at full speed. Enjoy fluent 4K/8K streaming, immersive AR/VR gaming, and blazing-fast downloads.
• Transmits data with Wi-Fi 7 clients across multiple bands simultaneously to increase throughput, reduce latency, and improve reliability for various networking behaviors.
• Works with EasyMesh routers and range extenders to form seamless whole home Mesh WiFi, preventing drops and lag when moving between signals.`,


        img: "images/tp4.jpg"

    },


    rt5: {
        name: "TP-Link Archer BE400 Dual-Band BE6500 WiFi 7 Router ",
        price: "₹10,199",
        desc: `About this product
 • Tri‑band 5400 Mbps performance — razor‑sharp speed for gaming, streaming and downloads.
• Low latency game optimization — prioritize gaming traffic for smoother matches.
• Multi‑device stability — handles many simultaneous connections without slowdowns.
• High‑gain external antennas — broader coverage and clearer signals across large homes.
• Advanced QoS — intuitive bandwidth control for lag‑free experiences where it matters.
• Robust security & parental controls — protect family devices and manage screen time.`,
        img: "images/tp5.webp"

    },


    rt6: {
        name: "D-Link dir-806in - AC750 Dual Band Wireless Router Multiple Operating Modes Router Black ",
        price: "₹1,179",
        desc: `About this product
 • D-Link DIR-806IN AC750 Dual Band Wireless Router (model DIR-806IN) in black. Device implements IEEE 802
• 11ac dual-band wireless operation across 2.4 GHz and 5 GHz frequency bands. 
• AC750 designation indicates combined theoretical wireless throughput up to 750 Mbps across both bands.`,
        img: "images/dro1.jpg"

    },


    rt7: {
        name: " D-Link DIR-2150 AC2100 Mbps MU-MIMO Dual Band Wi-Fi Router",
        price: "₹2,779",
        desc: `About this product
• D-Link DIR-2150 is a dual-band 802.11ac wireless router (AC2100) featuring MU-MIMO (multi-user multiple-input multiple-output) technology.
•  The unit provides concurrent 2.4 GHz and 5 GHz radios with an aggregate rated throughput of 2100 Mbps (commonly represented as up to 300 Mbps on 2.4 GHz and up to 1733 Mbps on 5 GHz).  
• AC750 designation indicates combined theoretical wireless throughput up to 750 Mbps across both bands.`,
        img: "images/dro2.jpg"

    },

    rt8: {
        name: "D-Link dir-811in 1200 Mbps Wireless Router White, Dual Band",
        price: "₹1,119",
        desc: `About this product
• D-Link DIR-811IN is a wireless router, model DIR-811IN, finished in white and specified as a dual-band device with an aggregate wireless throughput of 1200 Mbps
•  The product designation indicates simultaneous operation on 2.4 GHz and 5 GHz radio bands and an aggregate wireless data rate of 1200 Mbps.
• The unit is identified as part of D-Links DIR series by model number DIR-811IN and features integrated routing and radio hardware within a white enclosure
  consistent with a router form factor.`,
        img: "images/dro3.jpg"

    },


    rt9: {
        name: "D-Link Wireless N Router",
        price: "₹6,032",
        desc: `About this product
•Get the D-Link DIR-615 Wireless N Router at Ubuy India. Experience faster wireless signals with 300 Mbps transmission speed and intelligent antenna technology.`,
        img: "images/dro4.jpg"

    },



    rt10: {
        name: "D-Link R04 N300 Eagle PRO AI Advance Parental Control Router With Voice Control Assistant White",
        price: "₹1,549",
        desc: `About this product
• The D-Link R04 N300 Eagle PRO AI delivers fast, reliable home Wi-Fi with intelligent parental controls and built-in voice assistant support
  perfect for families, remote workers, and smart homes
•  Enjoy peace of mind with D-Link's 1-year limited warranty and Vlebazaar's trusted support, dependable delivery and hassle-free customer service for setup and aftercare.
• Voice Control Ready - Works with popular voice assistants for hands-free network control and convenienc`,
        img: "images/dro5.jpg"

    },

    rt11: {
        name: "Tenda AC5 V3 AC1200 Wireless Dual Band Wifi Router,Speed Up To 867Mbps/5Ghz + 300Mbps/2.4Ghz, IPV6, Parental Control",
        price: "₹1,449",
        desc: `About this product
•  Enjoy clearer video calls, lag-free gameplay and consistent coverage with four high-gain external antennas and easy app management. 
•  Small home offices that need stable wired and wireless connectivity. 
•  Apartment and small house owners seeking improved coverage and fewer dead spots. `,
        img: "images/ten1.jpg"

    },


    rt12: {
        name: "Tenda Wifi 6 Router For Home, AX1500 Dual Band Gigabit Router For Wireless Internet",
        price: "₹5,999",
        desc: `About this product
•  RX2Pro adopts MU-MIMO plus OFDMA to significantly improve network performance and efficiency, wipe out latency. 
•  Enjoy smoother and more stable streaming, gaming, downloading and more with WiFi speeds up to 1501Mbps (2.4GHz: 300Mbps, 5GHz: 1201Mbps)  
•  The Tenda WiFi Router RX2 Pro support both VPN Server and VPN Client (PPTP/L2TP). `,
        img: "images/ten2.jpg"

    },


    rt13: {
        name: "TENDA TE DH301 Wireless N300 High Power ADSL2 Modem Router",
        price: "₹2,899",
        desc: `About this product
• TENDA TE DH301 Wireless N300 High Power ADSL2 Modem Router (DH301).
•  Integrated ADSL2 modem and 802.11n wireless router operating on the single 2.4 GHz band with Wireless N300 throughput (up to 300 Mbps).
   High Power radio designation indicated in model name.  
•   Physical I/O includes an ADSL RJ11 connector, multiple Ethernet LAN (RJ45) ports and a DC power input.  `,
        img: "images/ten3.jpg"

    },



    rt14: {
        name: "TENDA TE-D151 N Wireless ADSL2+ Modem 150 Mbps Wireless Router White Single Band",
        price: "₹789",
        desc: `About this product
•  Networking functions include IP routing and NAT handling consistent with combined modem/router design.
•  The unit includes an ADSL RJ11 interface for telephone line connection, Ethernet LAN interfaces for wired network connection 
•  physical status LEDs, a hardware reset button and a dedicated power input. `,
        img: "images/ten4.jpg"

    },

    rt15: {
        name: "Tenda AC10 AC1200 Wireless Smart Dual-Band Gigabit Wifi Router, MU-MIMO, 4 Gigabit Ports",
        price: "₹1,849",
        desc: `About this product
• Tenda AC10 (AC1200) wireless dual-band router, model AC10, implements the IEEE 802.
• 11ac standard with AC1200-class combined throughput (approximately 300 Mbps on 2.4 GHz and 867 Mbps on 5 GHz).
• The unit supports MU-MIMO technology for simultaneous multi-client spatial streams and provides four Gigabit Ethernet ports for wired LAN connectivity plus a Gigabit WAN uplink. `,
        img: "images/ten5.jpg"

    },



    had1: {
        name: "Seagate One Touch HDD External Drive",
        price: "₹13,999",
        desc: `About this product
• Store and access photos and files on the go with Seagate One Touch HDD.
•  Featuring quick plug-and-play USB 3.0 connectivity to Windows or Mac, consolidate files with a single click or schedule automatic daily, weekly or monthly backups. 
•  High Capacity. Stellar Style. Refined and understated. Cosy and textured. One Touch comes in an array of styles and capacities made to compliment your signature look `,
        img: "images/hard1.webp"

    },

    had2: {
        name: "Seagate One Touch HDD External Drive",
        price: "₹13,999",
        desc: `About this product
• Store and access photos and files on the go with Seagate One Touch HDD.
•  Featuring quick plug-and-play USB 3.0 connectivity to Windows or Mac, consolidate files with a single click or schedule automatic daily, weekly or monthly backups. 
•  High Capacity. Stellar Style. Refined and understated. Cosy and textured. One Touch comes in an array of styles and capacities made to compliment your signature look `,
        img: "images/hd2.webp"

    },

    had3: {
        name: "Seagate One Touch HDD External Drive",
        price: "₹29,499",
        desc: `About this product
• Seagate Expansion desktop drive, add-on storage for your PC and Mac The Seaga
• Product type: COMPUTER_DRIVE_OR_STORAGE
• Compatible with Windows and Mac
• Easy-to-use storage solution `,
        img: "images/hd3.webp"

    },

    had4: {
        name: "SEAGATE GAME DRIVE FOR PS4 2TB",
        price: "₹29,499",
        desc: `About this product
• Boost your console's storage capacity with the Seagate Game Drive for PS4, the only external drive designed exclusively for PlayStation 4.
• 2TB capacity gives you storage for 50+ PS4 games.
• Plug-and-play setup will have your drive game-ready in moments.
• With Seagate Game Drive you can also take your entire game library to a friend's house and play on their console.
• Seagate Game Drive is compatible with PS4, PS4 Slim and PS4 Pro. `,
        img: "images/hd4.webp"

    },


    had5: {
        name: "Seagate Backup Plus Hub 4 TB External Hard Drive – USB 3.0",
        price: "₹7,899",
        desc: `About this product
• Store and access content for years to come with 4 TB in a USB drive
• A great external hard drive for Mac and Windows, this hub can charge mobile devices and transfer files from USB cameras and USB thumb drives via its two USB 3.0 ports
• Use seamlessly between Windows and Mac by installing the provided NTFS driver for Mac
• Complimentary four-month membership to the Adobe Creative Cloud Photography Plan’s photo and video editing apps (Must be redeemed within 1 year of drive registration. 
      Not available in all countries)
• Warranty : 3 Years Warranty
• Seagate Customer care contact Number : 000 800 440 1392 `,
        img: "images/hd5.webp"

    },


    had6: {
        name: "Seagate One Touch Hub Desktop External HDD",
        price: "₹65,799",
        desc: `About this product
• About this item
• A front-facing USB C and USB 3.0 port for connecting and recharging devices—even if your computer is off
• Password-protected external hard drive with USB hub to secure your digital life
• Out-of-the-box compatibility with Windows and Mac computers
• Includes Seagate Toolkit backup software for one-click and scheduled backups and file mirroring
• Actual storage capacity may vary due to differences between decimal and binary calculations. `,
        img: "images/hd6.webp"

    },



    // ➕ add remaining products
};

const params = new URLSearchParams(window.location.search);
const id = params.get("id");

if (products[id]) {
    document.getElementById("productName").innerText = products[id].name;
    document.getElementById("productPrice").innerText = products[id].price;
    document.getElementById("productDesc").innerText = products[id].desc;
    document.getElementById("productImage").src = products[id].img;
}

const buyButtons = document.querySelectorAll(".buy-btn");

buyButtons.forEach(btn => {
    btn.addEventListener("click", () => {
        if (!products[id]) {
            alert("Product not found");
            return;
        }

        const p = products[id];
        window.location.href =
            `./customer.html?name=${encodeURIComponent(p.name)}&price=${encodeURIComponent(p.price)}`;
    });
});

// ===== PROFILE DROPDOWN =====
const profileBtn = document.getElementById('profile-btn');
const profileDropdown = document.getElementById('profile-dropdown');

if (profileBtn && profileDropdown) {
    profileBtn.addEventListener('click', (e) => {
        e.stopPropagation();
        profileDropdown.classList.toggle('active');
    });

    document.addEventListener('click', (e) => {
        if (!e.target.closest('.profile-wrapper')) {
            profileDropdown.classList.remove('active');
        }
    });
}


