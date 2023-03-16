import { Component, OnInit } from '@angular/core';
import { FactionService } from 'src/app/Services/factions.service';
import { filter } from 'rxjs/operators';
import { Faction } from 'src/app/Models/factions';

@Component({
  selector: 'app-stratagems',
  templateUrl: './stratagems.component.html',
  styleUrls: ['./stratagems.component.scss']
})
export class StratagemsComponent implements OnInit {

  public factionList : Faction[];
  public mainFactionsList : Faction[];
  public currentFactionList: Faction[];

  constructor(
    private _FactionService: FactionService
    ) 
    {     
      this._FactionService.getFactions().subscribe(factions => {
        this.factionList = factions as Faction[]
        this.mainFactionsList = factions.filter((x: Faction) => x.parentId === '');
        this.currentFactionList = this.mainFactionsList;
      });
    }

  ngOnInit(): void {
  }


  public getSubfactions(faction: Faction){
    this.currentFactionList = this.factionList.filter(x => x.parentId === faction.abbreviation)
    console.log(this.currentFactionList)
  }
}
