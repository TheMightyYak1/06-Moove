export interface Assignment {
    id: string;
    title: string;
    type: string;
    description: string;
    fromLocation: string;
    toLocation: string;
    price: number;
    date: Date | null;
    accepted: boolean;
}

export class Assignment implements Assignment {

}

export class AssignmentFormValues {
    id?: string = undefined;
    title: string = '';
    type: string = '';
    description: string = '';
    fromLocation: string = '';
    toLocation: string = '';
    price: number = 0;
    date: Date | null = null;

    constructor(assignment?: AssignmentFormValues) {
        if(assignment) {
            this.id = assignment.id;
            this.title = assignment.title;
            this.type = assignment.type;
            this.fromLocation = assignment.fromLocation;
            this.toLocation = assignment.toLocation;
            this.price = assignment.price;
            this.date = assignment.date;
        }
    }
}