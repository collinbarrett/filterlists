import { useEffect, useState } from 'react';

interface TablePageSize {
    pageSize: number;
    isNarrowWindow: boolean;
}

export const useTablePageSizer = () => {
    const calculateSize = () => {
        return {
            pageSize: Math.floor((window.innerHeight - 211.5) / 56),
            isNarrowWindow: window.innerWidth < 576 ? true : false
        };
    }
    const [state, setState] = useState<TablePageSize>(calculateSize());
    useEffect(() => {
        const updatePageSize = () => { setState(calculateSize()) }
        window.addEventListener('resize', updatePageSize);
        return () => window.removeEventListener('resize', updatePageSize);
    }, []);
    return state;
}