﻿	ALTER TABLE [dbo].[CityMaster]
	ADD CONSTRAINT [PinIDFK]
	FOREIGN KEY (Pin)
	REFERENCES [PINMaster] (PINID)

	GO
	ALTER TABLE [dbo].[CityMaster]
	ADD CONSTRAINT [StateIDFK]
	FOREIGN KEY (State)
	REFERENCES [StateMaster](StateID)
