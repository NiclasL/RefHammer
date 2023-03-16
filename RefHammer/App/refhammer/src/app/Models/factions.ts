export class Faction {
    id: number;
    abbreviation: string;
    name: string;
    link: string;
    isSubfaction: string;
    parentId: string;
  
    constructor(id: number, abbreviation: string, name: string, link: string, isSubfaction: string, parentId: string) {
      this.id = id;
      this.abbreviation = abbreviation;
      this.name = name;
      this.link = link;
      this.isSubfaction = isSubfaction;
      this.parentId = parentId;
    }
  }