| COM1           | COM2         | BAR          |
| -------------- | ------------ | ------------ |
| NAV1<br />NAV2 | HDG<br />CRS | ALT<br />VS  |
| AV1            | AV2          | SPD<br />MCH |
| AV3            | AV4          | XPND         |

# AS530

//Microsoft/Generic/Avionics

## AV1
### LEFT KNOBS
#### STATE_AS530_LF_LG
AS530_LeftLargeKnob_Left#(>H:AS530_LeftLargeKnob_Left)
AS530_LeftLargeKnob_Right#(>H:AS530_LeftLargeKnob_Right)
AS530_LeftSmallKnob_Push#(>H:AS530_LeftSmallKnob_Push)
#### STATE_AS530_LF_SM
AS530_LeftSmallKnob_Left#(>H:AS530_LeftSmallKnob_Left)
AS530_LeftSmallKnob_Right#(>H:AS530_LeftSmallKnob_Right)
AS530_LeftSmallKnob_Push#(>H:AS530_LeftSmallKnob_Push)

## AV2
### RIGHT KNOBS
#### STATE_AS530_RT_LG
AS530_RightLargeKnob_Left#(>H:AS530_RightLargeKnob_Left)
AS530_RightLargeKnob_Right#(>H:AS530_RightLargeKnob_Right)
AS530_RightSmallKnob_Push#(>H:AS530_RightSmallKnob_Push)
#### STATE_AS530_RT_SM
AS530_RightSmallKnob_Left#(>H:AS530_RightSmallKnob_Left)
AS530_RightSmallKnob_Right#(>H:AS530_RightSmallKnob_Right)
AS530_RightSmallKnob_Push#(>H:AS530_RightSmallKnob_Push)

# AS430
//Microsoft/Generic/Avionics

## AV3
### LEFT KNOBS
#### STATE_AS430_LF_LG
AS430_LeftLargeKnob_Left#(>H:AS430_LeftLargeKnob_Left)
AS430_LeftLargeKnob_Right#(>H:AS430_LeftLargeKnob_Right)
AS430_LeftSmallKnob_Push#(>H:AS430_LeftSmallKnob_Push)
#### STATE_AS430_LF_SM
AS430_LeftSmallKnob_Left#(>H:AS430_LeftSmallKnob_Left)
AS430_LeftSmallKnob_Right#(>H:AS430_LeftSmallKnob_Right)
AS430_LeftSmallKnob_Push#(>H:AS430_LeftSmallKnob_Push)

## AV4
### RIGHT KNOBS
#### STATE_AS430_RT_LG
AS430_RightLargeKnob_Left#(>H:AS430_RightLargeKnob_Left)
AS430_RightLargeKnob_Right#(>H:AS430_RightLargeKnob_Right)
AS430_RightSmallKnob_Push#(>H:AS430_RightSmallKnob_Push)
#### STATE_AS430_RT_SM
AS430_RightSmallKnob_Left#(>H:AS430_RightSmallKnob_Left)
AS430_RightSmallKnob_Right#(>H:AS430_RightSmallKnob_Right)
AS430_RightSmallKnob_Push#(>H:AS430_RightSmallKnob_Push)

# AS1000
//Microsoft/Generic/Avionics

## AV1
### PFD FMS KNOBS
#### STATE_AS1000_PFD_LG
AS1000_PFD_FMS_Lower_DEC#(>H:AS1000_PFD_FMS_Lower_DEC)
AS1000_PFD_FMS_Lower_INC#(>H:AS1000_PFD_FMS_Lower_INC)
AS1000_PFD_FMS_Upper_PUSH#(>H:AS1000_PFD_FMS_Upper_PUSH)
#### STATE_AS1000_PFD_SM
AS1000_PFD_FMS_Upper_DEC#(>H:AS1000_PFD_FMS_Upper_DEC)
AS1000_PFD_FMS_Upper_INC#(>H:AS1000_PFD_FMS_Upper_INC)
AS1000_PFD_FMS_Upper_PUSH#(>H:AS1000_PFD_FMS_Upper_PUSH)

## AV2
### PFD RANGE KNOB
#### STATE_AS1000_PFD_RANGE
AS1000_PFD_RANGE_DEC#(>H:AS1000_PFD_RANGE_DEC)
AS1000_PFD_RANGE_INC#(>H:AS1000_PFD_RANGE_INC)

## AV3
### MFD FMS KNOBS
#### STATE_AS1000_MFD_LG
AS1000_MFD_FMS_Lower_DEC#(>H:AS1000_MFD_FMS_Lower_DEC)
AS1000_MFD_FMS_Lower_INC#(>H:AS1000_MFD_FMS_Lower_INC)
AS1000_MFD_FMS_Upper_PUSH#(>H:AS1000_MFD_FMS_Upper_PUSH)
#### STATE_AS1000_MFD_SM
AS1000_MFD_FMS_Upper_DEC#(>H:AS1000_MFD_FMS_Upper_DEC)
AS1000_MFD_FMS_Upper_INC#(>H:AS1000_MFD_FMS_Upper_INC)
AS1000_MFD_FMS_Upper_PUSH#(>H:AS1000_MFD_FMS_Upper_PUSH)

## AV4
### MFD RANGE KNOB
#### STATE_AS1000_MFD_RANGE
AS1000_MFD_RANGE_DEC#(>H:AS1000_MFD_RANGE_DEC)
AS1000_MFD_RANGE_INC#(>H:AS1000_MFD_RANGE_INC)

# AS3000 HORIZ 2X
//Asobo/TBM 930/Avionics

## AV1
### GTC TOP KNOBS (PILOT)
#### STATE_AS3000H_TSC1_TOP_LG
G3000_TSC_1_Top_Knob_Large_Dec#(>H:AS3000_TSC_Horizontal_1_TopKnob_Large_DEC)
G3000_TSC_1_Top_Knob_Large_Inc#(>H:AS3000_TSC_Horizontal_1_TopKnob_Large_INC)
G3000_TSC_1_Top_Knob_Short_Press#(>H:AS3000_TSC_Horizontal_1_TopKnob_Push)
G3000_TSC_1_Top_Knob_Long_Press#(>H:AS3000_TSC_Horizontal_1_TopKnob_Push_Long)
#### STATE_AS3000H_TSC1_TOP_SM
G3000_TSC_1_Top_Knob_Small_Dec#(>H:AS3000_TSC_Horizontal_1_TopKnob_Small_DEC)
G3000_TSC_1_Top_Knob_Small_Inc#(>H:AS3000_TSC_Horizontal_1_TopKnob_Small_INC)
G3000_TSC_1_Top_Knob_Short_Press#(>H:AS3000_TSC_Horizontal_1_TopKnob_Push)
G3000_TSC_1_Top_Knob_Long_Press#(>H:AS3000_TSC_Horizontal_1_TopKnob_Push_Long)

## AV2
### GTC BOTTOM KNOB (PILOT)
#### STATE_AS3000H_TSC1_BTM
G3000_TSC_1_Bottom_Knob_DEC#(>H:AS3000_TSC_Horizontal_1_BottomKnob_Small_DEC)
G3000_TSC_1_Bottom_Knob_Inc#(>H:AS3000_TSC_Horizontal_1_BottomKnob_Small_INC)
G3000_TSC_1_Bottom_Knob_Push#(>H:AS3000_TSC_Horizontal_1_BottomKnob_Push)

## AV3
### GTC TOP KNOBS (CO-PILOT)
#### STATE_AS3000H_TSC2_TOP_LG
G3000_TSC_2_Top_Knob_Large_Dec#(>H:AS3000_TSC_Horizontal_2_TopKnob_Large_DEC)
G3000_TSC_2_Top_Knob_Large_Inc#(>H:AS3000_TSC_Horizontal_2_TopKnob_Large_INC)
G3000_TSC_2_Top_Knob_Short_Press#(>H:AS3000_TSC_Horizontal_2_TopKnob_Push)
G3000_TSC_2_Top_Knob_Long_Press#(>H:AS3000_TSC_Horizontal_2_TopKnob_Push_Long)
#### STATE_AS3000H_TSC1_TOP_SM
G3000_TSC_2_Top_Knob_Small_Dec#(>H:AS3000_TSC_Horizontal_2_TopKnob_Small_DEC)
G3000_TSC_2_Top_Knob_Small_Inc#(>H:AS3000_TSC_Horizontal_2_TopKnob_Small_INC)
G3000_TSC_2_Top_Knob_Short_Press#(>H:AS3000_TSC_Horizontal_2_TopKnob_Push)
G3000_TSC_2_Top_Knob_Long_Press#(>H:AS3000_TSC_Horizontal_2_TopKnob_Push_Long)

## AV4
### GTC BOTTOM KNOB (CO-PILOT)
#### STATE_AS3000H_TSC2_BTM
G3000_TSC_2_Bottom_Knob_DEC#(>H:AS3000_TSC_Horizontal_2_BottomKnob_Small_DEC)
G3000_TSC_2_Bottom_Knob_Inc#(>H:AS3000_TSC_Horizontal_2_BottomKnob_Small_INC)
G3000_TSC_2_Bottom_Knob_Push#(>H:AS3000_TSC_Horizontal_2_BottomKnob_Push)

# AS3000 VERT 2X
//Asobo/Longitude/Avionics

## AV1
### JOYSTICK KNOB / MIDDLE KNOB (PILOT)
#### STATE_AS3000V_TSC1_LF
AS3000_TSC_Vertical_1_Joystick_Range_Zoom_Dec# (>H:AS3000_TSC_Vertical_1_Joystick_DEC)
AS3000_TSC_Vertical_1_Joystick_Range_Zoom_Inc# (>H:AS3000_TSC_Vertical_1_Joystick_INC)
AS3000_TSC_Vertical_1_Joystick_Push#(>H:AS3000_TSC_Vertical_1_Joystick_Push)
#### STATE_AS3000V_TSC1_MD
AS3000_TSC_Vertical_1_Middle_Knob_Dec#(>H:AS3000_TSC_Vertical_1_MiddleKnob_Dec)
AS3000_TSC_Vertical_1_Middle_Knob_Inc#(>H:AS3000_TSC_Vertical_1_MiddleKnob_Inc)
AS3000_TSC_Vertical_1_Middle_Knob_Button# (>H:AS3000_TSC_Vertical_1_MiddleKnob_Push)

## AV2
### RIGHT KNOBS (PILOT)
#### STATE_AS3000V_TSC1_LG
AS3000_TSC_Vertical_1_Right_Outer_Knob_Dec#(>H:AS3000_TSC_Vertical_1_RightKnob_Large_DEC)
AS3000_TSC_Vertical_1_Right_Outer_Knob_Inc#(>H:AS3000_TSC_Vertical_1_RightKnob_Large_INC)
AS3000_TSC_Vertical_1_Right_Inner_Knob_Button_Press#(E:SIMULATION TIME, second) 2 + (>L:myTimer)
AS3000_TSC_Vertical_1_Right_Inner_Knob_Button_Release#(E:SIMULATION TIME, second) (L:myTimer) < if{ (>H:AS3000_TSC_Vertical_1_RightKnob_Push) } els{ (>H:AS3000_TSC_Vertical_1_RightKnob_Push_Long) } 
#### STATE_AS3000V_TSC1_SM
AS3000_TSC_Vertical_1_Right_Inner_Knob_Dec#(>H:AS3000_TSC_Vertical_1_RightKnob_Small_DEC)
AS3000_TSC_Vertical_1_Right_Inner_Knob_Inc#(>H:AS3000_TSC_Vertical_1_RightKnob_Small_INC)
AS3000_TSC_Vertical_1_Right_Inner_Knob_Button_Press#(E:SIMULATION TIME, second) 2 + (>L:myTimer)
AS3000_TSC_Vertical_1_Right_Inner_Knob_Button_Release#(E:SIMULATION TIME, second) (L:myTimer) < if{ (>H:AS3000_TSC_Vertical_1_RightKnob_Push) } els{ (>H:AS3000_TSC_Vertical_1_RightKnob_Push_Long) } 

## AV3
### JOYSTICK KNOB / MIDDLE KNOB (CO-PILOT)
#### STATE_AS3000V_TSC2_LF
AS3000_TSC_Vertical_2_Joystick_Range_Zoom_Dec# (>H:AS3000_TSC_Vertical_2_Joystick_DEC)
AS3000_TSC_Vertical_2_Joystick_Range_Zoom_Inc# (>H:AS3000_TSC_Vertical_2_Joystick_INC)
AS3000_TSC_Vertical_2_Joystick_Push#(>H:AS3000_TSC_Vertical_2_Joystick_Push)
#### STATE_AS3000V_TSC2_MD
AS3000_TSC_Vertical_2_Middle_Knob_Dec#(>H:AS3000_TSC_Vertical_2_MiddleKnob_Dec)
AS3000_TSC_Vertical_2_Middle_Knob_Inc#(>H:AS3000_TSC_Vertical_2_MiddleKnob_Inc)
AS3000_TSC_Vertical_2_Middle_Knob_Button# (>H:AS3000_TSC_Vertical_2_MiddleKnob_Push)

## AV4
### RIGHT KNOBS (CO-PILOT)
#### STATE_AS3000V_TSC2_LG
AS3000_TSC_Vertical_2_Right_Outer_Knob_Dec#(>H:AS3000_TSC_Vertical_2_RightKnob_Large_DEC)
AS3000_TSC_Vertical_2_Right_Outer_Knob_Inc#(>H:AS3000_TSC_Vertical_2_RightKnob_Large_INC)
AS3000_TSC_Vertical_2_Right_Inner_Knob_Button_Press#(E:SIMULATION TIME, second) 2 + (>L:myTimer)
AS3000_TSC_Vertical_2_Right_Inner_Knob_Button_Release#(E:SIMULATION TIME, second) (L:myTimer) < if{ (>H:AS3000_TSC_Vertical_2_RightKnob_Push) } els{ (>H:AS3000_TSC_Vertical_2_RightKnob_Push_Long) } 
#### STATE_AS3000V_TSC2_SM
AS3000_TSC_Vertical_2_Right_Inner_Knob_Dec#(>H:AS3000_TSC_Vertical_2_RightKnob_Small_DEC)
AS3000_TSC_Vertical_2_Right_Inner_Knob_Inc#(>H:AS3000_TSC_Vertical_2_RightKnob_Small_INC)
AS3000_TSC_Vertical_2_Right_Inner_Knob_Button_Press#(E:SIMULATION TIME, second) 2 + (>L:myTimer)
AS3000_TSC_Vertical_2_Right_Inner_Knob_Button_Release#(E:SIMULATION TIME, second) (L:myTimer) < if{ (>H:AS3000_TSC_Vertical_2_RightKnob_Push) } els{ (>H:AS3000_TSC_Vertical_2_RightKnob_Push_Long) }

# G3X 2X

//Working Title/G3X-Touch/Avionics

## AV1
### LEFT KNOBS (PILOT)
#### STATE_G3X_1_LF_LG
Unit_1_Left_Outer_Knob_Decrease#(>H:AS3X_TOUCH_1_KNOB_OUTER_L_DEC)
Unit_1_Left_Outer_Knob_Increase#(>H:AS3X_TOUCH_1_KNOB_OUTER_L_INC)
#### STATE_G3X_1_LF_SM
Unit_1_Left_Inner_Knob_Decrease#(>H:AS3X_TOUCH_1_KNOB_INNER_L_DEC)
Unit_1_Left_Inner_Knob_Increase#(>H:AS3X_TOUCH_1_KNOB_INNER_L_INC)

## AV2
### RIGHT KNOBS (PILOT)
#### STATE_G3X_1_RT_LG
Unit_1_Right_Outer_Knob_Decrease#(>H:AS3X_TOUCH_1_KNOB_OUTER_R_DEC)
Unit_1_Right_Outer_Knob_Increase#(>H:AS3X_TOUCH_1_KNOB_OUTER_R_INC)
#### STATE_G3X_1_RT_SM
Unit_1_Right_Inner_Knob_Decrease#(>H:AS3X_TOUCH_1_KNOB_INNER_R_DEC)
Unit_1_Right_Inner_Knob_Increase#(>H:AS3X_TOUCH_1_KNOB_INNER_R_INC)

## AV3
### LEFT KNOBS (CO-PILOT)
#### STATE_G3X_2_LF_LG
Unit_2_Right_Outer_Knob_Decrease#(>H:AS3X_TOUCH_2_KNOB_OUTER_R_DEC)
Unit_2_Right_Outer_Knob_Increase#(>H:AS3X_TOUCH_2_KNOB_OUTER_R_INC)
#### STATE_G3X_2_LF_SM
Unit_2_Right_Inner_Knob_Decrease#(>H:AS3X_TOUCH_2_KNOB_INNER_R_DEC)
Unit_2_Right_Inner_Knob_Increase#(>H:AS3X_TOUCH_2_KNOB_INNER_R_INC)

## AV4
### RIGHT KNOBS (CO-PILOT)
#### STATE_G3X_2_RT_LG
Unit_2_Left_Outer_Knob_Decrease#(>H:AS3X_TOUCH_2_KNOB_OUTER_L_DEC)
Unit_2_Left_Outer_Knob_Increase#(>H:AS3X_TOUCH_2_KNOB_OUTER_L_INC)
#### STATE_G3X_2_RT_SM
Unit_2_Left_Inner_Knob_Decrease#(>H:AS3X_TOUCH_2_KNOB_INNER_L_DEC)
Unit_2_Left_Inner_Knob_Increase#(>H:AS3X_TOUCH_2_KNOB_INNER_L_INC)





