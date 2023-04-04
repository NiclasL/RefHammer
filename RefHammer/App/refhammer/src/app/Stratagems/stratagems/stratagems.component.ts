import { Component, OnInit } from '@angular/core';
import { FactionService } from 'src/app/Services/factions.service';
import { filter } from 'rxjs/operators';
import { Faction } from 'src/app/Models/factions';
import { StratagemService } from 'src/app/Services/stratagem.service copy';
import { Stratagem } from 'src/app/Models/stratagems';

@Component({
  selector: 'app-stratagems',
  templateUrl: './stratagems.component.html',
  styleUrls: ['./stratagems.component.scss']
})
export class StratagemsComponent implements OnInit {

  public factionList : Faction[];
  public mainFactionsList : Faction[];
  public currentFactionList: Faction[];
  public strats: Stratagem[];
  public factionStrats: Stratagem[];
  public displayStrats: Stratagem[];

  public currentFaction: string;

  constructor(
    private _FactionService: FactionService,
    private _stratagemService: StratagemService
    )
    {
      this._FactionService.getFactions().subscribe(factions => {
        this.factionList = factions as Faction[]
        this.mainFactionsList = factions.filter((x: Faction) => x.parentId === '');
        this.currentFactionList = this.mainFactionsList;
      });

      this._stratagemService.getStratagems().subscribe(strats => {
        this.strats = strats as Stratagem[]
      });
    }

  ngOnInit(): void {
  }


  public getSubfactions(faction: Faction){
    var parentId = "";
    this.currentFaction = faction.name;
    var stratlist: Stratagem[] = [];
    if (faction.parentId == null) {
      this.factionStrats = [];
    }
    this.currentFactionList = this.factionList.filter(x => x.parentId === faction.abbreviation);
    parentId = faction.abbreviation;
    if (faction.parentId != null) {
      this.strats.forEach(function (value) {
        if (value.type.includes(faction.name) || value.faction_id === parentId ){
          stratlist.push(value);
          return value;
        }
        return;
      });
    }
    this.factionStrats = stratlist;
    console.log(this.factionStrats);
  }

  public factionBack(){
    if(this.currentFactionList && this.currentFactionList[0]?.parentId != null) {
      this.currentFactionList = this.factionList.filter(x => x.abbreviation == this.currentFactionList[0].parentId);
    }
    else{
      this.currentFactionList = this.factionList;
    }
  }
}
